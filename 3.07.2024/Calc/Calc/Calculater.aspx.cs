using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calc
{
    public partial class Calculater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(Number1.Text);
            int number2 = int.Parse(Number2.Text);

            int result = number1 + number2;
            Result.Text ="Result : " + result.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(Number1.Text);
            int number2 = int.Parse(Number2.Text);

            int result = number1 - number2;
            Result.Text = "Result : " + result.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(Number1.Text);
            int number2 = int.Parse(Number2.Text);

            int result = number1 * number2;
            Result.Text = "Result : " + result.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(Number1.Text);
            int number2 = int.Parse(Number2.Text);

            int result = number1 / number2;
            Result.Text = "Result : " + result.ToString();
        }
    }
}