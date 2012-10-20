using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam
{
  public   class McQuestionBao
    {
      static McQuestionDao dao = new McQuestionDao();

      public static bool Add(McQuestion obj)
      {
          return dao.Add(obj);
      }


      public static List<McQuestion> GetQuestions()
      {
          return dao.Gets();
      }

      public static List<McQuestion> GetRandomQuestion(int any)
      {
          Random rnd = new Random();

          return dao.Gets().OrderBy(p => p.ID * rnd.Next()).Take(any).ToList();

      }
    }
}
