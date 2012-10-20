using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam
{
    public class BoolQuestionBao
    {
      static   BoolQuestionDao dao = new BoolQuestionDao();

        public static bool Add(BoolQuestion obj)
        {
            return dao.Add(obj);
        }
        public static List<BoolQuestion> GetQuestions()
        {
            return dao.Gets();
        }

        public static List<BoolQuestion> GetRandomQuestion(int any)
        {
            Random rnd=new Random();

            return dao.Gets().OrderBy(p => p.ID * rnd.Next()).Take(any).ToList();

        }
    }
}
