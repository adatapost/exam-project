using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam
{
    public class McQuestionDao : IDao<Exam.McQuestion>
    {
        public bool Add(McQuestion obj)
        {
            ExamDbEntities db = new ExamDbEntities();
            db.McQuestions.AddObject(obj);
            db.SaveChanges();
            return true;
        }

        public bool Update(McQuestion obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(McQuestion obj)
        {
            throw new NotImplementedException();
        }

        public McQuestion Get(McQuestion obj)
        {
            ExamDbEntities db=new ExamDbEntities();

            var que = db.McQuestions.Where(p => p.ID == obj.ID).FirstOrDefault();
            return que;
        }

        public List<McQuestion> Gets()
        {
            ExamDbEntities db = new ExamDbEntities();
            return db.McQuestions.ToList();
        }
    }
}
