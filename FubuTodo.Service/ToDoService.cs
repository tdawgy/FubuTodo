using System.Collections.Generic;
using System.Linq;
using FubuTodo.Domain;
using Raven.Client;

namespace FubuTodo.Service
{
  public class TodoService: ITodoService
  {
    private readonly IDocumentStore _documentStore;

    public TodoService(IDocumentStore documentStore)
    {
      _documentStore = documentStore;
    }

    public void Create(Todo todo)
    {
      using (var session = _documentStore.OpenSession())
      {
        session.Store(todo);
        session.SaveChanges();
      }
    }

    public void Delete(Todo todo)
    {
      using (var session = _documentStore.OpenSession())
      {
        session.Delete(todo);
        session.SaveChanges();
      }
    }

    public void Update(Todo todo)
    {
      using (var session = _documentStore.OpenSession())
      {
        //TODO might need to change this to first load the entity to bring it into the session for change tracking
        session.Store(todo);
        session.SaveChanges();
      }
    }

    public Todo GetTodo(string id)
    {
      using (var session = _documentStore.OpenSession())
      {
        var todo = session.Load<Todo>(id);

        return todo;
      }
    }

    public IEnumerable<Todo> GetAllTodos()
    {
      using (var session = _documentStore.OpenSession())
      {
        var todos = session.Query<Todo>().ToList();

        return todos;
      }
    }
  }
}