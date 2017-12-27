using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Banking_Advisor_bot.Data_Access_Layer;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Banking_Advisor_bot
{
    public partial class financialDecisionInput : System.Web.UI.Page
    {
        BankInterestDAL bankInt = new BankInterestDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void SubmitInput_Click(object sender, EventArgs e)
        {
            Session["var1"] = ddlLoan.SelectedItem.Text ;
            Session["var2"] = loanAmount.Text ;
            Session["var3"] = loanPeriod.Text;
            Session["var4"] = TxtInterest.Text;
            Response.Redirect("financialDecisionHelp.aspx");
        }

     
        protected void ddlLoanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string LoanType = Convert.ToString(ddlLoan.SelectedItem.Text);
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString);

            connection.Open();
            SqlCommand command = new SqlCommand("select * from Bank_interest where Loan_Type='" + LoanType + "' and Interest_rate=(select MIN(Interest_rate) from Bank_interest where Loan_Type='" + LoanType + "')", connection);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            connection.Close();
            TxtInterest.Text = ds.Tables[0].Rows[0]["Interest_rate"].ToString();
            ddlBankname.DataSource = ds;
            ddlBankname.DataTextField = "Bank_name";
            ddlBankname.DataValueField = "Id";
            ddlBankname.DataBind();
            ddlBankname.Items.Insert(0, new ListItem("--Select--", "0"));
           

        }
    }
}