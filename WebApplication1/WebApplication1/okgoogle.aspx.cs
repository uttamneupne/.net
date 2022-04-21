using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class okgoogle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int a, b, c;
            try
            {
                a = Convert.ToInt32(Txt1.Text);
                b = Convert.ToInt32(Txt2.Text);
                c = a + b;
                Txt3.Text = c.ToString();
            }
            catch(Exception exp)
            {
                Label1.Text=exp.ToString();
            }
        }

       
    }
}