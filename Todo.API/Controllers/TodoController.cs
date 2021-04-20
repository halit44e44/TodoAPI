using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Business.Abstract;
using Todo.Business.Concrete;
using Todo.Entities;

namespace Todo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private ITodoService _todoService;

        public TodoController()
        {
            _todoService = new TodoManager();
        }

        [HttpGet]
        public List<TodoSample> Get() 
        {
            return _todoService.GetAll();
        }

        [HttpGet("{id}")]
        public TodoSample Get(int id)
        {
            return _todoService.GetById(id);
        }

        [HttpPost]
        public TodoSample Create([FromBody]TodoSample todo)
        {
            return _todoService.Create(todo);
        }

        [HttpPut]
        public TodoSample Update([FromBody]TodoSample todo)
        {
            return _todoService.Update(todo);
        } 

        [HttpDelete("{id}")]
        public void Delete (int id)
        {
            _todoService.Delete(id);
        }
    }
}
