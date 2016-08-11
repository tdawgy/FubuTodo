using System;
using System.Web;
using System.Web.Mvc;
using FubuMVC.Core;
//using FubuMVC.Core.View;
//using Spark.Web.Mvc;

namespace FubuTodo.Web
{
  public class Global : HttpApplication
  {
    private FubuRuntime _runtime;

    protected void Application_Start(object sender, EventArgs e)
    {
      _runtime = FubuRuntime.For<AppFubuRegistry>();
      //ViewEngines.Engines.Add(new SparkViewFactory());
    }

    protected void Application_End(object sender, EventArgs e)
    {
      _runtime.Dispose();
    }
  }
}