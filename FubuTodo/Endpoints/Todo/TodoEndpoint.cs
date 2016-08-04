using System.Collections.Generic;
using FubuMVC.Core;

namespace FubuTodo.Web.Endpoints.Todo
{
  public class TodoEndpoint
  {
    [UrlPattern("Todo/List")] //overides the default translation of the action to a url (in this case, the get_index() with a default url pattern of "/index" will now have a blank url pattern, effectively turning it into the home page)
    public ListViewModel get_list()
    {
      var model = new ListViewModel();
      model.Todos.Add(new Domain.Todo("Test Todo"));

      return model;
    }
  }

  public class ListViewModel
  {
    public ListViewModel()
    {
      Todos = new List<Domain.Todo>();
    }

    public List<Domain.Todo> Todos { get; set; }
  }
}