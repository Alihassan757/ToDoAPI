using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.Models;

namespace ToDoAPI.InMemoryDataStorage
{
    public class ToDoItemStorage
    {

        public ToDoItemStorage()
        {
            var todoItem1 = new TodoItem();
            todoItem1.Id = TodoItems.Any() ? TodoItems.Keys.Max() + 1 : 1;
            todoItem1.Name = "Training Session";
            todoItem1.IsComplete = false;
            TodoItems.Add(todoItem1.Id, todoItem1);
            var todoItem2 = new TodoItem();
            todoItem2.Id = TodoItems.Keys.Max() + 1;
            todoItem2.Name = "Ali and Shahid will Practice";
            todoItem2.IsComplete = false;
            TodoItems.Add(todoItem2.Id, todoItem2);
      
        }

        public IDictionary<long, TodoItem> TodoItems { get; set; } = new ConcurrentDictionary<long, TodoItem>();

        public void Add(TodoItem todoItem)
        {
            todoItem.Id = TodoItems.Keys.Max() + 1;
            TodoItems.Add(todoItem.Id, todoItem);
        }

        public TodoItem Get(long id)
        {
            var todoItem = TodoItems[id];
            return todoItem;
        }

    }
}
