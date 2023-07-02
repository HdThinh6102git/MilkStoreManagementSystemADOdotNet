using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalADOdotNET.BS_Layer;

namespace FinalADOdotNET
{
    public partial class fMain : Form
    {

        #region Biến 
        DataTable dtMilk = null;
        BL_HoaDon dbPayMent = new BL_HoaDon();
        float tempMilkPrice;
        string    tempMilkID;
        int oldSoldAmount;
        int oldExtantAmount;
        int newSoldAmount;
        int newExtantAmount;
        string err;

        #endregion

        #region Hàm khởi tạo 

        public fMain()
        {
            InitializeComponent();
            LoadDataMilk();
        }

        #endregion


        #region Hàm xử lí 

       

        void LoadDataMilk()
        {
            try
            {
                dtMilk = new DataTable();
                dtMilk.Clear();

                DataSet ds = dbPayMent.GetMilk();
                dtMilk = ds.Tables[0];
     
                // Đưa dữ liệu lên DataGridView
                dgvMilk.DataSource = dtMilk;
                // Thay đổi độ rộng cột 
                dgvMilk.AutoResizeColumns();
                //Xóa trống các đối tượng 
               
                //Không cho thao tác trên các textbox tên sữa và tổng tiền 
                this.txtMilkName.Enabled = false;
                this.txtTotalMoney.Enabled = false;
                

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table MILK. Lỗi rồi!!!");
            }
        }


        private bool oldCustomer(int phoneNum)  //chưa xử lí xong
        {
            return false;
        }
        

        private float  TotalBoughtMoney(int cusBoughtAmount, float price)
        {
            return cusBoughtAmount * price;
        }

        private void computeNewMilkAmount(int oldExtantAmount, int oldSoldAmount, ref int  newExtantAmount, int cusBoughtAmount,ref  int newSoldAmount)
        {
            newExtantAmount = oldExtantAmount - cusBoughtAmount;
            newSoldAmount = oldSoldAmount + cusBoughtAmount;
        }


        #endregion

        #region Events 


        

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();

            this.Hide();
            f.ShowDialog();
            this.LoadDataMilk();
            this.Show();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            BL_HoaDon blHoaDon = new BL_HoaDon();
            this.txtTotalMoney.Text = this.TotalBoughtMoney((int)this.nmCusBoughtAmount.Value, this.tempMilkPrice).ToString();

            #region Add newCustomer hoặc nếu đã tồn tại thì Update 
            //Nếu đã tồn tại 
            if (oldCustomer(int.Parse(this.txtCusPhoneNum.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat)))
                
            {
                blHoaDon.UpdateCustomer(int.Parse(this.txtCusPhoneNum.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat),
                    this.TotalBoughtMoney((int)this.nmCusBoughtAmount.Value, this.tempMilkPrice),
                    ref err);
            }
            else //Chưa tồn tại 
            {
                try
                {
                    //Thực hiện lệnh 

                    blHoaDon.AddCustomer(this.txtCusName.Text.Trim(), this.cbCusGender.Text.Trim(),
                         int.Parse(this.txtCusPhoneNum.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat),
                        this.TotalBoughtMoney((int)this.nmCusBoughtAmount.Value, this.tempMilkPrice),
                        ref err);
                    
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }

            #endregion

            #region Update milkAmount
            //Thực hiện lệnh 
           
            
            computeNewMilkAmount(this.oldExtantAmount, this.oldSoldAmount, ref this.newExtantAmount, (int)this.nmCusBoughtAmount.Value,ref  this.newSoldAmount);
            blHoaDon.UpdateMilkAmount(this.tempMilkID, this.newExtantAmount, this.newSoldAmount, ref err);


            #endregion

           


            #region Insert  bill

            try
            {
                //Thực hiện lệnh 
                
                blHoaDon.InsertBill(this.txtCusName.Text.Trim(), 
                    int.Parse(this.tempMilkID.Trim(), CultureInfo.InvariantCulture.NumberFormat),
                    float.Parse(this.txtTotalMoney.Text.Trim(), CultureInfo.InvariantCulture.NumberFormat), 
                    (int)this.nmCusBoughtAmount.Value, ref err);

            }
            catch
            {
                MessageBox.Show("Không thêm bill  được. Lỗi rồi!");
            }

            #endregion

            this.USP_GetBillTableAdapter.Fill(this.MilkShopProjectDataSet.USP_GetBill);

            this.reportViewer1.RefreshReport();
            //Load lại dữ liệu trên DatagridView 
            LoadDataMilk();
            //Thông báo 
            MessageBox.Show("Đã thanh toán");
        }

        private void dgvMilk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Thứ tự dòng hiện hành 
            int r = dgvMilk.CurrentCell.RowIndex;
            //Chuyển thông tin lên panel hoặc biến tạm
            this.tempMilkID =
                dgvMilk.Rows[r].Cells[0].Value.ToString();
            this.txtMilkName.Text =
                dgvMilk.Rows[r].Cells[1].Value.ToString();
            this.tempMilkPrice =
                float.Parse(dgvMilk.Rows[r].Cells[2].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
            this.oldExtantAmount =
                int.Parse(dgvMilk.Rows[r].Cells[3].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
            this.nmCusBoughtAmount.Text =
                dgvMilk.Rows[r].Cells[3].Value.ToString();
            this.oldSoldAmount =
                int.Parse(dgvMilk.Rows[r].Cells[4].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);

        }

        private void btnReload_Click(object sender, EventArgs e)
        {

            this.txtCusName.ResetText();
            this.txtCusPhoneNum.ResetText();
            this.cbCusGender.ResetText();
            this.txtMilkName.ResetText();
            this.txtTotalMoney.ResetText();
            this.nmCusBoughtAmount.ResetText();
            dbPayMent.UpdateStatusBill(ref err);
            this.USP_GetBillTableAdapter.Fill(this.MilkShopProjectDataSet.USP_GetBill);

            this.reportViewer1.RefreshReport();
        }

        private void fMain_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MilkShopProjectDataSet.USP_GetBill' table. You can move, or remove it, as needed.
            this.USP_GetBillTableAdapter.Fill(this.MilkShopProjectDataSet.USP_GetBill);

            this.reportViewer1.RefreshReport();
        }






        #endregion


    }
}
