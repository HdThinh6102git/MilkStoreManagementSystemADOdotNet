using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalADOdotNET.DB_Layer;
using System.Data;


namespace FinalADOdotNET.BS_Layer
{
    public class BL_HoaDon
    {

        #region Khởi tạo
        DBMain db = null;
        public BL_HoaDon()
        {
            db = new DBMain();
        }

        #endregion

        #region Hàm xử lí

        public DataSet GetMilk()
        {
            return db.ExecuteQueryDataSet("Select *  from Milk", System.Data.CommandType.Text);
        }

        public bool AddCustomer(string name, string gender,int phoneNum ,float totalBoughtMoney, ref string err)
        {
            string sqlString = "Insert into Customer (name, gender, phoneNum, totalBoughtMoney) values(N'" + name + "', N'"+gender+"',"+phoneNum+","+totalBoughtMoney+")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateCustomer(int phoneNum, float totalBoughtMoney, ref string err)
        {
            string sqlString = "Update Customer set  totalBoughtMoney = " + totalBoughtMoney + "  where phoneNum = " + phoneNum + " ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool UpdateMilkAmount(string milkID,int extantAmount,int soldAmount, ref string err)
        {
            string sqlString = "Update Milk set extantAmount = " + extantAmount + ", soldAmount = "+soldAmount+" where milkID = '" + milkID + "' ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool InsertBill(string cusName,  int milkID, float totalPrice, int totalAmount, ref string err)
        {
            
            string sqlString = "Insert into Bill (cusName , milkID, totalPrice, totalAmount, status) values(N'" + cusName + "'," + milkID + "," + totalPrice + ", "+totalAmount+", 1)";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet GetBilkByDate(DateTime fromDate, DateTime toDate)
        {
            return db.ExecuteQueryDataSet
                ("Select b.cusName as N'Tên khách hàng', b.BillDate as N'Ngày',m.MilkName as N'Tên sữa', b.totalAmount as N'Số lượng', b.TotalPrice as N'Tổng tiền'" +
                " from Bill as b, Milk as m " +
                "where billDate >= '"+fromDate+"' AND billDate <= '"+toDate+"'AND b.MilkID = m.MilkID ", System.Data.CommandType.Text);
        }
        public bool UpdateStatusBill(ref string err)
        {
            string sqlString = "Update Bill set status = 0 ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        #endregion 


    }
}
