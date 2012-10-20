using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridView1.DataSource = Exam.BoolQuestionBao.GetQuestions();
            GridView1.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Exam.BoolQuestion bq = new Exam.BoolQuestion()
        {
            Question =  TextBox1.Text ,
            Ans1 = TextBox2.Text ,
            Ans2 = TextBox3.Text ,
            CorrectAnswer = int.Parse(DropDownList1.SelectedValue)
        };
        Exam.BoolQuestionBao.Add(bq);

        GridView1.DataSource = Exam.BoolQuestionBao.GetQuestions();
        GridView1.DataBind();
    }
}