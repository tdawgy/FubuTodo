using System.Collections.Generic;
using System.Linq;
using FubuMVC.Core;
using FubuTodo.Service;

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
    public ListViewModel get_list()
    {
      var model = new ListViewModel(_toDoService.GetAllTasks());

      return model;
    }
  }

  public class ListViewModel
  {
    public ListViewModel()
    {
      Todos = new List<Domain.Todo>();
    }

    public ListViewModel(IEnumerable<Domain.Todo> todos)
    {
      Todos = todos.ToList();
    }

    public List<Domain.Todo> Todos { get; set; }
  }
}