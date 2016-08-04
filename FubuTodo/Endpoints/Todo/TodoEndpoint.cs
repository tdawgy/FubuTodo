using FubuMVC.Core;
using FubuTodo.Service;
using FubuTodo.Web.Endpoints.Todo.ViewModels;

namespace FubuTodo.Web.Endpoints.Todo
{
  public class TodoEndpoint
  {
    public TodoEndpoint(ToDoService toDoService)
    {
      _toDoService = toDoService;
    }

    private readonly ToDoService _toDoService;

    [UrlPattern("Todo/List")] //overides the default translation of the action to a url (in this case, the get_index() with a default url pattern of "/index" will now have a blank url pattern, effectively turning it into the home page)
    public List get_list()
    {
      var model = new List(_toDoService.GetAllTasks());

      return model;
    }

    [UrlPattern("Todo/Create")] //overides the default translation of the action to a url (in this case, the get_index() with a default url pattern of "/index" will now have a blank url pattern, effectively turning it into the home page)
    public void post_todo(Create todo)
    {
      var todoToCreate = new Domain.Todo(todo.Name);
      _toDoService.Create(todoToCreate);
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