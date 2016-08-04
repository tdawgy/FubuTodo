using FubuMVC.Core.Registration;
using Raven.Client;
using Raven.Client.Document;

namespace FubuTodo.RavenDb
{
  public class RavenDbRegistry : ServiceRegistry
  {
    public RavenDbRegistry()
    {
      var documentStore = InitializeDocumentStore();
      AddService(documentStore);
    }

    private IDocumentStore InitializeDocumentStore()
    {
      var documentStore = new DocumentStore
      {
        Url = "http://localhost:8080",
        DefaultDatabase = "Todos"
      };
      documentStore.Initialize();

      return documentStore;
    }
  }
}
