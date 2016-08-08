using System.Collections.Generic;
using FubuTodo.Domain;

namespace FubuTodo.Service
{
  interface ITodoService
  {
    void Create(Todo todo);
    void Delete(Todo todo);
    void Update(Todo todo);
    IEnumerable<Todo> GetAllTasks();
  }
}
