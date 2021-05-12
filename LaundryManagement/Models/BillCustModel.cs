using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LaundryManagement.Models
{
    public class BillCustModel
    {
        public int BillingId { get; set; }
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustMobileNumber { get; set; }
       
       
    }

    public class BillCustContext
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-BDOM6TKO;Initial Catalog=LaundryManagmentSystem;Integrated Security=true");

       
        
        public List<BillCustModel> getBillCustDetails()
        {
            try
            {
                List<BillCustModel> objListBillCust = new List<BillCustModel>();
                SqlCommand cmd = new SqlCommand("sp_GetBillCustomerDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    BillCustModel billCustObj = new BillCustModel();
                    billCustObj.BillingId = Convert.ToInt32(dr[0]);
                    billCustObj.CustId = Convert.ToInt32(dr[1]);
                    billCustObj.CustName = Convert.ToString(dr[2]);
                    billCustObj.CustMobileNumber = Convert.ToString(dr[3]);

                    objListBillCust.Add(billCustObj);
                }

                return objListBillCust;
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }

        }
    }
}