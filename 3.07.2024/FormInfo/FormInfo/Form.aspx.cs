using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormInfo
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = Text1.Text;
            string id = Text2.Text;
            string email = Text3.Text;

            string gender = RadioButtonList1.SelectedItem != null ? RadioButtonList1.SelectedItem.Text : "";

            List<string> Courses = new List<string>();
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    Courses.Add(item.Value);
                }
            }

            string c = string.Join(",", Courses);

            string desc = TextBox1.Text;

            Label1.Text = name;
            Label2.Text = id;
            Label3.Text = email;
            Label4.Text = gender;
            Label5.Text = c;
            Label6.Text = desc;
        }
    }
}