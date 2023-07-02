using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalADOdotNET.DB_Layer;
using System.Data;
namespace FinalADOdotNET.BS_Layer
{
    class BL_QuanLiSua
    {

        #region Khởi tạo 
        DBMain db = null;
        public BL_QuanLiSua()
        {
            db = new DBMain();
        }

        #endregion

        #region Hàm xử lí 
        public DataSet GetMilk()
        {
            return db.ExecuteQueryDataSet("Select * from Milk", System.Data.CommandType.Text);
        }
        public bool AddMilk(string name, float price,int extantAmount ,ref string err)
        {
            string sqlString = "Insert into Milk  (MilkName, price, extantAmount) values(N'" + name + "', " + price + ", "+extantAmount+")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteMilk(ref string err, string milkID)
        {
            string sqlString = "Delete From milk  Where milkID='" + milkID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateMilk(string milkID, string name, float price,int extantAmount, ref string err)
        {
            string sqlString = "Update Milk set MilkName = N'" + name + "', price = " + price + " , extantAmount = "+extantAmount+" where milkID = '" + milkID + "' ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet FindInterestedMilk()
        {

            return db.ExecuteQueryDataSet("select * from Milk where soldAmount = (select max(soldAmount) from Milk)", System.Data.CommandType.Text);

        }

        #endregion

    }
}
