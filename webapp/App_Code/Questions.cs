using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Objects.DataClasses;
using Exam;

 
public class Questions : List<EntityObject>
{
    public bool IsBool(int index)
    {
        if (index >= Count)
            return false;
        BoolQuestion que=this[index] as BoolQuestion ;
        if (que == null)
            return false;
        return true;
    }
    public bool IsBlank(int index)
    {
        if (index >= Count)
            return false;
        BlanksQuestion que = this[index] as BlanksQuestion;
        if (que == null)
            return false;
        return true;
    }
     public bool IsMCQ(int index)
    {
        if (index >= Count)
            return false;
        McQuestion que = this[index] as McQuestion;
         
;
        if (que == null)
            return false;
        return true;
    }

     public BoolQuestion getBool(int index)
     {
         if (IsBool(index))
             return this[index] as BoolQuestion;
         return null;
     }
     public BlanksQuestion  getBlank(int index)
     {
         if (IsBlank(index))
             return this[index] as BlanksQuestion ;
         return null;
     }
     public McQuestion getMCQ(int index)
     {
         if (IsMCQ(index))
             return this[index] as McQuestion;
         return null;
     }
     public static Questions GetQuestions()
     {
         Questions ques = new Questions();
         if (HttpContext.Current.Session["ques"] == null)
         {
             foreach (EntityObject obj in BoolQuestionBao.GetRandomQuestion(2))
             {
                 ques.Add(obj);
             }

             foreach (EntityObject obj in BlanksQuestionBao.GetRandomQuestion(2))
             {
                 ques.Add(obj);
             }
             foreach (EntityObject obj in McQuestionBao.GetRandomQuestion(2))
             {
                 ques.Add(obj);
             }
             HttpContext.Current.Session["ques"] = ques;
         }
         ques = HttpContext.Current.Session["ques"] as Questions;
         return ques;
     }

}