using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam
{
    public class BlanksQuestionBao
    {

        static BlanksQuestionDao dao = new BlanksQuestionDao();

        public static bool Add(BlanksQuestion obj)
        {
            return dao.Add(obj);
        }

        public static List<BlanksQuestion> GetQuestions()
        {
            return dao.Gets();
        }

        public static List<BlanksQuestion> GetRandomQuestion(int any)
        {
            Random rnd = new Random();

            return dao.Gets().OrderBy(p => p.ID * rnd.Next()).Take(any).ToList();

        }
    }
}
