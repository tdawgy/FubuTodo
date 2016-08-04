using FubuMVC.Core.Registration;
using Raven.Client;
using Raven.Client.Document;
using StructureMap;
using StructureMap.Graph;

namespace FubuTodo
{
  public class CoreRegistry : ServiceRegistry
  {
    public CoreRegistry()
    {
      //var documentStore = InitializeDatabase();

      Scan(x =>
      {
        //scans the calling assembly for items to automatically add to the container that follow the default conventions
        //the main one to take note of is 'Fubu is IFubu'
        x.TheCallingAssembly();
        x.WithDefaultConventions();
      });

      //var container = new Container(config =>
      //{
      //  config.ForSingletonOf<IDocumentStore>()
      //    .Use(documentStore);

      //  config.For<IDocumentSession>()
      //    .Use(documentStore.OpenSession());
      //});
    }

    //public DocumentStore InitializeDatabase()
    //{
    //  var documentStore = new DocumentStore()
    //  {
    //    DefaultDatabase = "FubuTodo",
    //    Url = "http://localhost:8081"
    //  };

    //  documentStore.Initialize();

    //  return documentStore;
    //}
  }
}