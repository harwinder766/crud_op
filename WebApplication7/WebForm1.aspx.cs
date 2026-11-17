using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["Id"].DefaultValue = TextBox1.Text;
            SqlDataSource1.InsertParameters["Name"].DefaultValue = TextBox2.Text;
            SqlDataSource1.InsertParameters["Class"].DefaultValue = TextBox3.Text;
            SqlDataSource1.Insert();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlDataSource1.UpdateParameters["Id"].DefaultValue = TextBox1.Text;
            SqlDataSource1.UpdateParameters["Name"].DefaultValue = TextBox2.Text;
            SqlDataSource1.UpdateParameters["Class"].DefaultValue = TextBox3.Text;
            SqlDataSource1.Update();
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlDataSource1.DeleteParameters["Id"].DefaultValue = TextBox1.Text;
            SqlDataSource1.Delete();
            GridView1.DataBind();
        }
    }
}