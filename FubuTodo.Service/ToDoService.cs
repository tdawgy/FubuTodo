using System.Collections.Generic;
using System.Linq;
using FubuTodo.Domain;
using Raven.Client;

namespace FubuTodo.Service
{
  public class ToDoService
  {
    private readonly IDocumentStore _documentStore;

    public ToDoService(IDocumentStore documentStore)
    {
      _documentStore = documentStore;
    }

    public void Create(Todo todo)
    {
      using (var session = _documentStore.OpenSession())
      {
        session.Store(todo);
      }
    }

    public void Delete(Todo todo)
    {
      using (var session = _documentStore.OpenSession())
      {
        session.Delete(todo);
      }
    }

    public void Update(Todo todo)
    {
      using (var session = _documentStore.OpenSession())
      {
        //TODO might need to change this to first load the entity to bring it into the session for change tracking
        session.Store(todo);
      }
    }

    public IEnumerable<Todo> GetAllTasks()
    {
      using (var session = _documentStore.OpenSession())
      {
        var tasks = session.Query<Todo>().ToList();
        return tasks;
      }
    }
  }
}