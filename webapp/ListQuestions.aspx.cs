using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListQuestions : System.Web.UI.Page
{

    public int Index
    {
        set
        {
            ViewState["index"] = value;
        }
        get
        {
            if (ViewState["index"] == null)
                ViewState["index"] = 0;

            return int.Parse(ViewState["index"].ToString());

        }
    }
    Questions ques = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["start"] = DateTime.Now;



        }
        ques = Questions.GetQuestions();
        if (ques.IsMCQ(Index))
        {
            Label1.Text = ques.getMCQ(Index).Question;
            MultiView1.ActiveViewIndex = 0;
        }
        else
            if (ques.IsBlank(Index))
            {
                Label2.Text = ques.getBlank(Index).Question;
                MultiView1.ActiveViewIndex = 1;
            }
            else
                if (ques.IsBool(Index))
                {
                    Label3.Text = ques.getBool(Index).Question;
                    MultiView1.ActiveViewIndex = 2;

                }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Index = Index + 1;
        if (Index >= ques.Count)
            Response.Redirect("ResultPage.aspx");

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        DateTime start = DateTime.Parse(Session["start"].ToString());
        TimeSpan span = DateTime.Now - start;
        double diff = 30 - span.TotalSeconds;

        if (diff <= 0)
        {
            Response.Redirect("ResultPage.aspx");
        }
        Label4.Text = diff.ToString("N");
    }
}