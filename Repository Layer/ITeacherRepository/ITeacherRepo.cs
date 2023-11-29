using Domain_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Layer.ITeacherRepository
{
    public interface ITeacherRepo<T> where T : Teachers
    {
  
            IEnumerable<T> GetAll();
            T Get(int teacher_Id);
            void Insert(T entity);
            void Update(T entity);
            void Delete(T entity);
            void SaveChanges();
    }
   
}

