using System.Collections.Generic;
using System.Linq;

namespace FubuTodo.Web.Endpoints.Todo.ViewModels
{
  public class List
  {
    public List()
    {
      Todos = new List<Domain.Todo>();
    }

    public List(IEnumerable<Domain.Todo> todos)
    {
      Todos = todos.ToList();
    }

    public List<Domain.Todo> Todos { get; set; }
  }
}