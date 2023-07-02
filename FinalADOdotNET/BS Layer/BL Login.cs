using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalADOdotNET.DB_Layer;
using System.Data;

namespace FinalADOdotNET.BS_Layer
{
    public class BL_Login
    {

        #region Khởi tạo 
        DBMain db = null;
        public BL_Login()
        {
            db = new DBMain();
        }

        #endregion

        #region Hàm xử lí 

        public bool Login(string userName, string passWord)
        {
            string sqlString  = "Select * From Account where userName = N'"+userName+"' AND passWord = N'"+passWord+"'";
            DataTable result = db.ExecuteQueryDataTable(sqlString, CommandType.Text);
            return result.Rows.Count > 0;
        }


        #endregion 

    }
}
