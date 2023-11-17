using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApp2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn=new SqlConnection(ConfigurationManager.ConnectionStrings["hello"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id=int.Parse(TextBox1.Text);
            string name=TextBox2.Text;
            string dept=TextBox3.Text;
            double salary=double.Parse(TextBox4.Text);
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["hello"].ToString());
            conn.Open();
            string myquery="insert into Employee values('"+id+"','"+name+ "','"+dept+ "','"+salary+"')";
            SqlCommand cmd=new SqlCommand(myquery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Label1.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBox1.Text);
            string name = TextBox2.Text;
            string dept = TextBox3.Text;
            double salary = double.Parse(TextBox4.Text);
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["hello"].ToString());
            conn.Open();
            string myquery = "update Employee set Name='" + name + "', Dept='" + dept + "', Salary='" + salary + "' where Id='" + id + "'";
            SqlCommand cmd=new SqlCommand( myquery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Label2.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBox1.Text);
            
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["hello"].ToString());
            conn.Open();
            string myquery = "delete from Employee where Id='" + id + "'";
            SqlCommand cmd=new SqlCommand(myquery, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Label3.Visible = true;
        }
    }
}