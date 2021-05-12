using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LaundryManagement.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductWashPrice { get; set; }
        public int ProductDryPrice { get; set; }
        public int ProductIronPrice { get; set; }


   
        public bool ProductIsAvailable { get; set; }

        public string ProductDesc { get; set; }
    }

    public class ProductContext
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-BDOM6TKO;Initial Catalog=LaundryDB;Integrated Security=true");
        //public List<EmployeeModel> getEmployees()
        //{
        //    List<EmployeeModel> objlist = new List<EmployeeModel>();
        //    SqlCommand cmd = new SqlCommand("spr_getEmployeeDetails", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        EmployeeModel emp = new EmployeeModel();
        //        emp.EmpId = Convert.ToInt32(dr[0]);
        //        emp.EmpName = Convert.ToString(dr[1]);
        //        emp.EmpSalary = Convert.ToInt32(dr[2]);
        //        objlist.Add(emp);
        //    }

        //    return objlist;
        //}

        public int SaveProduct(ProductModel objProduct)
        {
            SqlCommand cmd = new SqlCommand("spr_insertProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@ProductName", objProduct.ProductName);
            cmd.Parameters.AddWithValue("@ProductPrice", objProduct.ProductWashPrice);
            cmd.Parameters.AddWithValue("@ProductPrice", objProduct.ProductDryPrice);
            cmd.Parameters.AddWithValue("@ProductPrice", objProduct.ProductIronPrice);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        //public EmployeeModel getEmployeeById(int? id)
        //{
        //    EmployeeModel emp = new EmployeeModel();
        //    SqlCommand cmd = new SqlCommand("spr_getEmployeeDetailsbyId", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@empid", id);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        emp.EmpId = Convert.ToInt32(dr[0]);
        //        emp.EmpName = Convert.ToString(dr[1]);
        //        emp.EmpSalary = Convert.ToInt32(dr[2]);
        //    }
        //    return emp;
        //}


        //public int UpdateEmployees(EmployeeModel emp)
        //{
        //    SqlCommand cmd = new SqlCommand("spr_updateEmployeeDetails", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    con.Open();
        //    cmd.Parameters.AddWithValue("@Empid", emp.EmpId);
        //    cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
        //    cmd.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);
        //    int i = cmd.ExecuteNonQuery();
        //    con.Close();
        //    return i;
        //}

        //public int DeleteEmployee(int? id)
        //{
        //    SqlCommand cmd = new SqlCommand("spr_deleteEmployeeDetails", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    con.Open();
        //    cmd.Parameters.AddWithValue("@empid", id);

        //    int i = cmd.ExecuteNonQuery();
        //    con.Close();
        //    return i;
        //}

    }
}