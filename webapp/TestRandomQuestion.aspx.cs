using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestRandomQuestion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       GridView1.DataSource= Exam.BoolQuestionBao.GetRandomQuestion(int.Parse(TextBox1.Text));
       GridView1.DataBind();
    }
}