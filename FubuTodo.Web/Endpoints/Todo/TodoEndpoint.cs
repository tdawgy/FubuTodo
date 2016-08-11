using FubuMVC.Core.Continuations;
using FubuMVC.Core.ServiceBus.Events;
using FubuTodo.Service;
using FubuTodo.Web.Endpoints.Todo.ViewModels;

namespace FubuTodo.Web.Endpoints.Todo
{
  public class TodoEndpoint
  {
    public TodoEndpoint(TodoService toDoService)
    {
      _toDoService = toDoService;
    }

    private readonly TodoService _toDoService;

    public List get_list()
    {
      var model = new List(_toDoService.GetAllTodos());

      return model;
    }

    public Create get_create()
    {
      return new Create();
    }

    public Update get_update(Update model)
    {
      var todo = _toDoService.GetTodo(model.Id);

      return new Update(todo);
    }

    public FubuContinuation post_create(Create todo)
    {
      var todoToCreate = new Domain.Todo(todo.Name, todo.IsComplete);
      _toDoService.Create(todoToCreate);

      return FubuContinuation.RedirectTo<TodoEndpoint>(endpoint => endpoint.get_list());
    }

    public FubuContinuation post_update(Update model)
    {
      var todo = _toDoService.GetTodo(model.Id);
      todo.IsComplete = model.IsComplete;
      todo.Name = model.Name;

      _toDoService.Update(todo);

      return FubuContinuation.RedirectTo<TodoEndpoint>(endpoint => endpoint.get_list());
    }

    public FubuContinuation delete_todo(Delete model)
    {
      _toDoService.Delete(model.Todo);

      return FubuContinuation.RedirectTo<TodoEndpoint>(endpoint => endpoint.get_list());
    }
  }
}