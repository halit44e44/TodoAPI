using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Business.Abstract;
using Todo.DataAccsess;
using Todo.DataAccsess.Abstract;
using Todo.DataAccsess.Concrete;
using Todo.Entities;

namespace Todo.Business.Concrete
{
    public class TodoManager : ITodoService
    {
        /* 
         *
         *Önemli Olan Nokta Burası Tek tek aynı işlemleri yapmak yerine _todoRepository adındaki değişkene DataAccsess de yaptıklarımızı atıyoruz. 
         *Ve olduğu gibi çağırıyoruz.
         *
         */
        private ITodoRepository _todoRepository;
        public TodoManager()
        {
            _todoRepository = new TodoRepository();
        }


        public TodoSample Create(TodoSample todo)
        {
            return _todoRepository.Create(todo);
            /*
            using (var todoDbContext = new TodoDbContext())
            {
                todoDbContext.TodoSamples.Add(todo);
                todoDbContext.SaveChanges();
                return todo;

            }
            */
        }

        public void Delete(int id)
        {
            _todoRepository.Delete(id);
            /*
            using (var todoDbContext = new TodoDbContext())
            {
                var deleteTodo = GetById(id);
                todoDbContext.TodoSamples.Remove(deleteTodo);
                todoDbContext.SaveChanges();
            }
            */
        }

        public List<TodoSample> GetAll()
        {
            return _todoRepository.GetAll();
            /*
            using (var todoDbContext = new TodoDbContext())
            {
                return todoDbContext.TodoSamples.ToList();
            }
            */
        }

        public TodoSample GetById(int id)
        {
            return _todoRepository.GetById(id);
            /*
            using (var todoDbContext = new TodoDbContext())
            {
                return todoDbContext.TodoSamples.Find(id);
            }
            */
        }

        public TodoSample Update(TodoSample todo)
        {
            return _todoRepository.Update(todo);
            /*
            using (var todoDbContext = new TodoDbContext())
            {
                todoDbContext.TodoSamples.Update(todo);
                todoDbContext.SaveChanges();
                return todo;
            }
            */
        }
    }
}
