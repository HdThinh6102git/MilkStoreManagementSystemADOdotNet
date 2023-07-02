using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalADOdotNET.BS_Layer;

namespace FinalADOdotNET
{
    public partial class fAdmin : Form
    {

        #region Biến quản lí NV
        DataTable dtEmployee = null;
        bool AddNV;
        string err;
        BL_QuanliNV dbEmployee = new BL_QuanliNV();
        #endregion

        #region Biến quản lí sữa 
        
        DataTable dtMilk = null;
        bool AddMilk;
        string tempMilkID;
        BL_QuanLiSua dbMilk = new BL_QuanLiSua();
        #endregion

        #region Biến quản lí doanh thu 
        DataTable dtBill = null;
        BL_HoaDon dbBill = new BL_HoaDon();
        #endregion


        #region Khởi tạo 
        public fAdmin()
        {
            InitializeComponent();
            LoadAdmin();
        }
        void LoadAdmin()
        {
            
            LoadDataBill();
            LoadDataNV();
            LoadDataMilk();
            dtpkToDate.Value = DateTime.Now;
        }
        #endregion

        #region Hàm quản lí NV

        #region Hàm xử lí 


        void LoadDataNV()
        {
            try
            {
                dtEmployee = new DataTable();
                dtEmployee.Clear();
                dbEmployee.ComputeSalary(ref err);
                DataSet ds = dbEmployee.GetEmployee();
                dtEmployee = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvEmployee.DataSource = dtEmployee;
                // Thay đổi độ rộng cột 
                dgvEmployee.AutoResizeColumns();
                //xóa trống các đối tượng trong Panel 
                this.txtEmName.ResetText();
                this.txtEmID.ResetText();
                this.nmWorkHour.ResetText();
                //Không cho thao tác trên các textbox
                this.txtEmName.Enabled = false;
                this.txtEmID.Enabled = false;
                this.nmWorkHour.Enabled = false;
                //Không cho thao tác trên các nút lưu và hủy 
                this.btnSaveNV.Enabled = false;
                this.btnCancelNV.Enabled = false;
                //this.panelNV.Enabled = false;
                //Cho thao tác trên các nút Thêm/Sửa/Xóa
                this.btnAddNV.Enabled = true;
                this.btnDeleteNV.Enabled = true;
                this.btnUpdateMilk.Enabled = true;
                this.btnFindNV.Enabled = true;
                //dgvEmployee_CellClick(null, null);

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table EMPLOYEE. Lỗi rồi!!!");
            }
        }
        
        
        #endregion

        #region Envents 
        


        private void fAdmin_Load(object sender, EventArgs e)
        {
            //LoadDataNV();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Thứ tự dòng hiện hành 
            int r = dgvEmployee.CurrentCell.RowIndex;
            //Chuyển thông tin lên panel 
            this.txtEmID.Text =
                dgvEmployee.Rows[r].Cells[0].Value.ToString();
            this.txtEmName.Text =
                dgvEmployee.Rows[r].Cells[1].Value.ToString();
            this.nmWorkHour.Text =
                dgvEmployee.Rows[r].Cells[3].Value.ToString();
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến thêm 
            AddNV = true;
            // Xóa trống các đối tượng trong panel 
            this.txtEmID.ResetText();
            this.txtEmName.ResetText();
            //Cho thao tác trên các textbox
            this.txtEmName.Enabled = true;
            this.nmWorkHour.Enabled = true;
            //Cho thao tác trên các nút Lưu / Hủy 
            this.btnSaveNV.Enabled = true;
            this.btnCancelNV.Enabled = true;
            //Không cho thao tác trên các nút thêm/xóa/sửa
            this.btnUpdateNV.Enabled = false;
            this.btnAddNV.Enabled = false;
            this.btnFindNV.Enabled = false;
            this.btnDeleteNV.Enabled = false;
            //Đưa con trỏ đến TextField txtIDEmployee
            this.txtEmName.Focus();

        }

        private void btnSaveNV_Click(object sender, EventArgs e)
        {
            //Mở kết nối 
            //Thêm dữ liệu 
            if (AddNV)
            {
                try
                {
                    //Thực hiện lệnh 
                    BL_QuanliNV blNV = new BL_QuanliNV();
                    blNV.AddEmployee( this.txtEmName.Text.Trim(),(float)this.nmWorkHour.Value, ref err);
                    //Load lại dữ liệu trên DataGridView 
                    LoadDataNV();
                    //Thông báo 
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi !!!");
                }
            }else //sửa dữ liệu 
            {
                //Thực hiện lệnh 
                BL_QuanliNV blNV = new BL_QuanliNV();
                blNV.UpdateEmployee(this.txtEmID.Text.Trim(), this.txtEmName.Text.Trim(), (float)this.nmWorkHour.Value, ref err);
                //Load lại dữ liệu trên DataGridView 
                LoadDataNV();
                //Thông báo 
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            try
            {
                //thực hiện lệnh 
                //lấy thứ tự record hiện hành 
                int r = dgvEmployee.CurrentCell.RowIndex;
                // Lấy mã employee hiện hành 
                string strEmployee =
                    dgvEmployee.Rows[r].Cells[0].Value.ToString();
                //Viết lệnh Sql
                //hiện thông báo xác nhận việc xóa mẫu tin 
                //khai báo biến trả lời 
                DialogResult ansWer;
                //Hiển thị hộp thoại hỏi đáp 
                ansWer = MessageBox.Show("Do you want to delete?", "Your Answer",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Kiểm tra có nhập chọn nút Yes hay không 
                if(ansWer == DialogResult.Yes)
                {
                    dbEmployee.DeleteEmployee(ref err, strEmployee);
                    //Cập nhật lại DataGridView 
                    LoadDataNV();
                    //Thông báo 
                    MessageBox.Show("Deleted");
                }
                else
                {
                    //Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }

            }
            catch
            {
                MessageBox.Show("Không xóa được lỗi rồi");
            }
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            //Kích hoạt biến sửa 
            AddNV = false;
            //Cho thao tác trên các textbox
            this.txtEmName.Enabled = true;
            this.nmWorkHour.Enabled = true;
            //Cho phép thao tác trên các nút lưu/hủy 
            this.btnSaveNV.Enabled = true;
            this.btnCancelNV.Enabled = true;
            //Không cho thao tác trên các nút thêm/xóa/sửa/tìm /ID 
            this.btnAddNV.Enabled = false;
            this.btnDeleteNV.Enabled = false;
            this.btnUpdateNV.Enabled = false;
            this.btnFindNV.Enabled = false;
            //Đưa con trỏ đến textField txtname 
            this.txtEmName.Focus();
        }

        private void btnCancelNV_Click(object sender, EventArgs e)
        {
            //Xóa trống các đối tượng trong Panel 
            this.txtEmID.ResetText();
            this.txtEmName.ResetText();
            this.nmWorkHour.ResetText();
            //Không cho thao tác trên các textbox
            this.txtEmName.Enabled = false;
            this.txtEmID.Enabled = false;
            this.nmWorkHour.Enabled = false;
            //Cho thao tác trên các nút thêm / xóa / sửa 

            this.btnAddNV.Enabled = true;
            this.btnDeleteNV.Enabled = true;
            this.btnUpdateNV.Enabled = true;
            //Không cho thao tác trên các nút Lưu/Hủy
            this.btnSaveNV.Enabled = false;
            this.btnCancelNV.Enabled = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataNV();
        }

        private void btnFindNV_Click(object sender, EventArgs e)
        {
            try
            {
                dtEmployee = new DataTable();
                dtEmployee.Clear();
                DataSet ds = dbEmployee.FindEmployee();
                dtEmployee = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvEmployee.DataSource = dtEmployee;
                // Thay đổi độ rộng cột 
                dgvEmployee.AutoResizeColumns();
               
                //Không cho thao tác trên các nút lưu/thêm/xóa/sửa
                this.btnSaveNV.Enabled = false;
                this.btnCancelNV.Enabled = false;

                this.btnAddNV.Enabled = false ;
                this.btnDeleteNV.Enabled = false ;
                this.btnUpdateMilk.Enabled = false;
                this.btnFindNV.Enabled = false;
                this.btnReload.Enabled = true;
                //dgvEmployee_CellClick(null, null);

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table EMPLOYEE. Lỗi rồi!!!");
            }
        }

        #endregion

        #endregion


        #region Hàm quản lí sữa 

        #region Hàm xử lí 

        void LoadDataMilk()
        {
            try
            {
                dtMilk = new DataTable();
                dtMilk.Clear();

                DataSet ds = dbMilk.GetMilk();
                dtMilk = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvMilk.DataSource = dtMilk;
                // Thay đổi độ rộng cột 
                dgvMilk.AutoResizeColumns();
                //Xóa trống các đối tượng 
                this.txtMilkName.ResetText();
                this.txtsoldAmount.ResetText();
                this.nmExtantAmount.ResetText();
                this.nmMilkPrice.ResetText();
                this.txtsoldAmount.Enabled = false;
                this.txtMilkName.Enabled = false;
                this.nmExtantAmount.Enabled = false;
                this.nmMilkPrice.Enabled = false;
                //Không cho thao tác trên các nút lưu/hủy bỏ 
                this.btnSaveMilk.Enabled = false;
                this.btnCancelMilk.Enabled = false;
                //Cho thao tác trên các nút thêm/xóa/sửa/tìm kiếm 
                this.btnAddMilk.Enabled = true;
                this.btnDeleteMilk.Enabled = true;
                this.btnUpdateMilk.Enabled = true;
                this.btnFindMilk.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table MILK. Lỗi rồi!!!");
            }
        }

        #endregion

        #region Events 


        private void btnReloadMilk_Click(object sender, EventArgs e)
        {
            LoadDataMilk();
        }

        private void btnAddMilk_Click(object sender, EventArgs e)
        {
            //Kích hoạt biến thêm 
            AddMilk = true;
            //Xóa trống đối tượng trong panel 
            this.txtMilkName.ResetText();
            this.txtsoldAmount.ResetText();
            this.nmMilkPrice.ResetText();
            this.nmExtantAmount.ResetText();
            this.txtMilkName.Enabled = true;
            this.nmMilkPrice.Enabled = true;
            this.nmExtantAmount.Enabled = true; 
            //Cho thao tác trên các nút Lưu/Hủy 
            this.btnSaveMilk.Enabled = true;
            this.btnCancelMilk.Enabled = true;
            //Không cho thao tác trên các nút thêm/xóa/sửa/tìm/reload 
            this.btnAddMilk.Enabled = false;
            this.btnDeleteMilk.Enabled = false;
            this.btnUpdateMilk.Enabled = false;
            this.btnFindMilk.Enabled = false;
            this.btnReloadMilk.Enabled = false;
            //Đưa con trỏ đến TextField txtMilkName
            this.txtMilkName.Focus();
        }

        private void btnSaveMilk_Click(object sender, EventArgs e)
        {
            //Mở kết nối 
            //Thêm dữ liệu 
            if (AddMilk)
            {
                try
                {
                    //Thực hiện lệnh 
                    BL_QuanLiSua blSua = new BL_QuanLiSua();
                    blSua.AddMilk(this.txtMilkName.Text.Trim(), (float)this.nmMilkPrice.Value, (int)this.nmExtantAmount.Value, ref err);
                    //Load lại dữ liệu lên DataGridView 
                    LoadDataMilk();
                    //Thông báo 
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else //Sửa dữ liệu
            {
                //Thực hiện lệnh 
                BL_QuanLiSua blSua = new BL_QuanLiSua();
                blSua.UpdateMilk(this.tempMilkID, this.txtMilkName.Text.Trim(), (float)this.nmMilkPrice.Value, (int)this.nmExtantAmount.Value, ref err);
                //Load lại dữ liệu trên DatagridView 
                LoadDataMilk();
                //Thông báo 
                MessageBox.Show("Đã sửa xong");
            }
        }

        private void btnDeleteMilk_Click(object sender, EventArgs e)
        {
            try
            {
                //thực hiện lệnh 
                //lấy thứ tự record hiện hành 
                int r = dgvMilk.CurrentCell.RowIndex;
                //Lấy mã Milk hiện hành 
                string strMilk =
                    dgvMilk.Rows[r].Cells[0].Value.ToString();

                //Hiện thông báo xác nhận việc xóa mẫu tin
                //Khai báo biến trả lời 
                DialogResult ansWer;
                //Hiển thị hộp thoại hỏi đáp 
                  ansWer = MessageBox.Show("Do you want to delete?", "Your answer", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Kiểm tra có chọn nút Yes hay không 
                if(ansWer == DialogResult.Yes)
                {
                    dbMilk.DeleteMilk(ref err, strMilk);
                    //Cập nhật lại DatagridView 
                    LoadDataMilk();
                    //Thông báo 
                    MessageBox.Show("Deleted");
                }
                else
                {
                    //Thông báo 
                    MessageBox.Show("Không thực hiện được việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được lỗi rồi!");
            }
        }

        private void dgvMilk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Thứ tự dòng hiện hành 
            int r = dgvMilk.CurrentCell.RowIndex;
            //Chuyển thông tin lên panel 
            this.tempMilkID =
                dgvMilk.Rows[r].Cells[0].Value.ToString();
            this.txtMilkName.Text =
                dgvMilk.Rows[r].Cells[1].Value.ToString();
            this.nmMilkPrice.Text =
                dgvMilk.Rows[r].Cells[2].Value.ToString();
            this.nmExtantAmount.Text =
                dgvMilk.Rows[r].Cells[3].Value.ToString();
            this.txtsoldAmount.Text =
                dgvMilk.Rows[r].Cells[4].Value.ToString();
        }

        private void btnUpdateMilk_Click(object sender, EventArgs e)
        {
            //Kích hoạt biến sửa 
            AddMilk = false;
            //Cho phép thao tác trên các nút lưu/hủy 
            this.btnSaveMilk.Enabled = true;
            this.btnCancelMilk.Enabled = true;
            this.txtMilkName.Enabled = true;
            this.nmMilkPrice.Enabled = true;
            this.nmExtantAmount.Enabled = true;
            //Không cho thao tác trên các nút thêm/xóa/sửa/tìm 
            this.btnAddMilk.Enabled = false;
            this.btnDeleteMilk.Enabled = false;
            this.btnUpdateMilk.Enabled = false;
            this.btnFindMilk.Enabled = false;
            //Đưa con trỏ đến textField txtMilkName
           
            this.txtMilkName.Focus();
        }

        private void btnCancelMilk_Click(object sender, EventArgs e)
        {
            //Xóa trống các đối tượng trong panel 
            this.txtMilkName.ResetText();
            this.txtsoldAmount.ResetText();
            this.nmMilkPrice.ResetText();
            this.nmExtantAmount.ResetText();
            this.txtsoldAmount.Enabled = false;
            this.txtMilkName.Enabled = false;
            this.nmExtantAmount.Enabled = false;
            this.nmMilkPrice.Enabled = false;
            //Cho thao tác trên các nút thêm/xóa/sửa/tìm
            this.btnAddMilk.Enabled = true;
            this.btnDeleteMilk.Enabled = true;
            this.btnUpdateMilk.Enabled = true;
            this.btnFindMilk.Enabled = true;
            //Không cho thao tác trên các nút lưu/hủy 
            this.btnSaveMilk.Enabled = false;
            this.btnCancelMilk.Enabled = false; 
        }

        private void btnFindMilk_Click(object sender, EventArgs e)
        {
            try
            {
                dtMilk = new DataTable();
                dtMilk.Clear();
                DataSet ds = dbMilk.FindInterestedMilk();
                dtMilk = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvMilk.DataSource = dtMilk;
                // Thay đổi độ rộng cột 
                dgvMilk.AutoResizeColumns();

                //Không cho thao tác trên các nút lưu/thêm/xóa/sửa
                this.btnSaveMilk.Enabled = false;
                this.btnCancelMilk.Enabled = false;

                this.btnAddMilk.Enabled = false;
                this.btnDeleteMilk.Enabled = false;
                this.btnUpdateMilk.Enabled = false;
                this.btnFindMilk.Enabled = false;
                this.btnReloadMilk.Enabled = true;
                //dgvEmployee_CellClick(null, null);

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table MILK. Lỗi rồi!!!");
            }
        }




        #endregion

        #endregion



        #region Hàm quản lí doanh thu

        #region Hàm xử lí 
        void LoadDataBill()
        {
            try
            {
                dtBill = new DataTable();
                dtBill.Clear();

                DataSet ds = dbBill.GetBilkByDate(this.dtpkFromDate.Value, this.dtpkToDate.Value);
                dtBill = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvBill.DataSource = dtBill;
                // Thay đổi độ rộng cột 
                dgvBill.AutoResizeColumns();
                

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table BILL. Lỗi rồi!!!");
            }
        }
        #endregion

        #region Events 

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadDataBill();
        }


        #endregion

        #endregion
    }
}
