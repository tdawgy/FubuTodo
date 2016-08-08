using FubuMVC.Core;
using FubuMVC.Core.Continuations;
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

    [Get("Todo/List")]
    public List get_list()
    {
      var model = new List(_toDoService.GetAllTasks());

      return model;
    }

    [Post("Todo/Create")]
    public FubuContinuation post_todo(Create todo)
    {
      var todoToCreate = new Domain.Todo(todo.Name);
      _toDoService.Create(todoToCreate);

      return FubuContinuation.RedirectTo<TodoEndpoint>(endpoint => endpoint.get_list());
    }

    public void put_todo(Update model)
    {
      //_toDoService.Update();
    }

    public void delete_todo(Delete model)
    {
      _toDoService.Delete(model.Todo);
    }
  }
}