using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam
{
  public  class BlanksQuestionDao : IDao<Exam.BlanksQuestion>

    {
        public bool Add(BlanksQuestion obj)
        {
            ExamDbEntities db = new ExamDbEntities();
            db.BlanksQuestions.AddObject(obj);
            db.SaveChanges();
            return true;
        }

        public bool Update(BlanksQuestion obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(BlanksQuestion obj)
        {
            throw new NotImplementedException();
        }

        public BlanksQuestion Get(BlanksQuestion obj)
        {
            throw new NotImplementedException();
        }

        public List<BlanksQuestion> Gets()
        {
            ExamDbEntities db = new ExamDbEntities();
           return  db.BlanksQuestions.ToList();
        }
    }
}
