using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Entities;

namespace Todo.Business.Abstract
{
    public interface ITodoService
    {
        List<TodoSample> GetAll();

        TodoSample GetById(int id);

        TodoSample Create(TodoSample todo);

        TodoSample Update(TodoSample todo);

        void Delete(int id); //Void geriye değer döndürmüyor.
    }
}
