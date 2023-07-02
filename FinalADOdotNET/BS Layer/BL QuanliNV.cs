using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalADOdotNET.DB_Layer;
using System.Data;

namespace FinalADOdotNET.BS_Layer
{
    public class BL_QuanliNV
    {

        #region Khởi tạo 
        DBMain db = null; 
        public BL_QuanliNV()
        {
            db = new DBMain();
        }

        #endregion

        #region Hàm xử lí 

        public DataSet GetEmployee()
        {
            
            return db.ExecuteQueryDataSet("Select * from Employee", System.Data.CommandType.Text);
        }
        public bool AddEmployee( string name,float workhour ,ref string err)
        {
            string sqlString = "Insert into Employee (name, workhour) values(N'"+name+"', "+workhour+")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool DeleteEmployee(ref string err, string IDEmployee)
        {
            string sqlString = "Delete From Employee Where ID='" + IDEmployee + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool UpdateEmployee(string IDEmployee, string name,  float workhour, ref string err)
        {
            string sqlString = "Update Employee set name = N'"+name+"', " +
                "workhour = "+workhour+"  where ID = '"+IDEmployee+"' ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet FindEmployee()
        {
           
            return db.ExecuteQueryDataSet("select * from Employee where workhour = (select max(workhour) from employee)", System.Data.CommandType.Text);

        }
        public bool  ComputeSalary( ref string err)
        {
            int salaryPerHour = 25000;
            string sqlString = "update employee set salary = workhour * "+salaryPerHour+"  ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            
        }

        #endregion

    }
}
