using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam
{
    public class BoolQuestionDao : IDao<BoolQuestion>
    {
        
        public bool Add(BoolQuestion obj)
        {
            ExamDbEntities db = new ExamDbEntities();

            db.AddToBoolQuestions(obj);
            db.SaveChanges();
            return true;
        }

        public bool Update(BoolQuestion obj)
        {
            ExamDbEntities db = new ExamDbEntities();
            var que = db.BoolQuestions.Where(p => p.ID == obj.ID).FirstOrDefault();
            if (que == null)
                return false;
            que.Question = obj.Question;
            que.Ans1 = obj.Ans1;
            que.Ans2 = obj.Ans2;
            que.CorrectAnswer = obj.CorrectAnswer;
            db.SaveChanges();
            return true;

        }

        public bool Delete(BoolQuestion obj)
        {
            ExamDbEntities db = new ExamDbEntities();
            var que = db.BoolQuestions.Where(p => p.ID == obj.ID).FirstOrDefault();
            if (que == null)
                return false;
            db.DeleteObject(que);
            db.SaveChanges();
            return true;
        }

        public BoolQuestion Get(BoolQuestion obj)
        {
            ExamDbEntities db = new ExamDbEntities();
            return db.BoolQuestions.Where(p => p.ID == obj.ID).FirstOrDefault();
        }

        public List<BoolQuestion> Gets()
        {
            ExamDbEntities db = new ExamDbEntities();
            return db.BoolQuestions.ToList();
        }
    }
}
