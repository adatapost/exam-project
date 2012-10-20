using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam
{
   public interface IDao<T>
    {
        bool Add(T obj);
        bool Update(T obj);
        bool Delete(T obj);
        T Get(T obj);
        List<T> Gets();

    }
}
