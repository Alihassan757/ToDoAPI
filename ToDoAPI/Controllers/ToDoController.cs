using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoAPI.InMemoryDataStorage;

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {

        [HttpGet]
        [Route("GetTodoItemById/{id}")]
        public IActionResult Get(long id)
        {
            var toDoItemStorage = new ToDoItemStorage();
            var todoItem = toDoItemStorage.Get(id);
            return Ok(todoItem);
        }


    }
}
