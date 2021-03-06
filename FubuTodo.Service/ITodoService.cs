﻿using System.Collections.Generic;
using FubuTodo.Domain;

namespace FubuTodo.Service
{
  interface ITodoService
  {
    void Create(Todo todo);
    void Delete(Todo todo);
    void Update(Todo todo);
    Todo GetTodo(string id);
    IEnumerable<Todo> GetAllTodos();
  }
}
