using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList2.Models;

namespace ToDoList2.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}
