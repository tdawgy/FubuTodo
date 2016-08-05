using System;
using FubuMVC.Core.Registration;
using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Embedded;
using Raven.Database.Server;

namespace FubuTodo.RavenDb
{
  public class RavenDbRegistry : ServiceRegistry
  {
    public RavenDbRegistry()
    {
      AddService(DocumentStore);
    }

    public static IDocumentStore DocumentStore { get; } = InitializeDocumentStore();

    private static IDocumentStore InitializeDocumentStore()
    {
      var documentStore = new EmbeddableDocumentStore
      {
        UseEmbeddedHttpServer = true,
        DataDirectory = "database"
      };

      documentStore.Initialize();

      return documentStore;
    }
  }
}
