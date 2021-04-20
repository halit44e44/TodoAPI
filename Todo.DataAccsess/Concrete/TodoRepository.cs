using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.DataAccsess.Abstract;
using Todo.Entities;

namespace Todo.DataAccsess.Concrete
{
    /*
     * Bir Abstract Klasöründe bir interface oluşturduk ve burada işlemesi için interface'i çağırdık. 
     */
    public class TodoRepository : ITodoRepository
    {
        public TodoSample Create(TodoSample todo)
        {
            using (var todoDbContext = new TodoDbContext())
            {
                /*
                 * Koşul Yazılabilir. Sorgular yapılabilir.
                 * Dönen Bir Veri Varsa Db'e Ekle denilebilir.
                 */
                todoDbContext.TodoSamples.Add(todo);
                todoDbContext.SaveChanges();
                return todo;
            }
        }

        public void Delete(int id)
        {
            using (var todoDbContext = new TodoDbContext())
            {
                var deleteOtel = GetById(id); // x Id elemanı getir
                if (deleteOtel != null) // Bir veri varmı (is_numeric(id) Eklenebilir. Kodu bilmiyorum.)
                {
                    todoDbContext.TodoSamples.Remove(deleteOtel); // Atıığımız değişkendeki veriyi db'den kaldır.
                    todoDbContext.SaveChanges(); // Değişiklikleri Kaydet.
                }
                
            }
        }
        /*
         * todoDbContent adındanki değişkene verileri aktarıp return ettiriyoruz.
         * ToList diyerek ne kadar veri varsa bize dönderiyor.
         */
        public List<TodoSample> GetAll()
        {
            using (var todoDbContext = new TodoDbContext())
            {
                return todoDbContext.TodoSamples.ToList();
            }
        }
        /*
         *Buradada aynı işlemi find methodu ile yapıyoruz Id'e göre bize gerekli alanı çağırıyor.
         */
        public TodoSample GetById(int id)
        {
            using (var todoDbContext = new TodoDbContext())
            {
                return todoDbContext.TodoSamples.Find(id);
            }
        }

        public TodoSample Update(TodoSample todo)
        {
            using (var todoDbContext = new TodoDbContext())
            {
                /*
                 * İf koşulları Eklenebilir. aynı şekilde.
                 */
                todoDbContext.TodoSamples.Update(todo);
                todoDbContext.SaveChanges();
                return todo;
            }
        }
    }
}
