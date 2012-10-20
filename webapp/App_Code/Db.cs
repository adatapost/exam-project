using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exam;

 
public class Db
{
    public static string CnStr { get; set; }

    public static void getQues()
    {
        ExamDbEntities db = new ExamDbEntities();
        Random rnd = new Random();
        var result = db.Tests.GroupBy(p => p.CID).Select(q => q.OrderBy(r => r.QID)).ToList();
        foreach (var t in result)
        {
            foreach (var k in t.OrderBy(p => p.CID * rnd.Next()).Take(2))
            {
                Console.WriteLine(k.QID + " " + k.CID + " " + k.Question);
            }
        }
        
    }

}