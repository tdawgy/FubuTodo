﻿using FubuMVC.Core;
using TraceLevel = FubuMVC.Core.TraceLevel;

namespace FubuTodo.Web
{
  public class AppFubuRegistry : FubuRegistry
  {
    public AppFubuRegistry()
    {
      //grab all classes that are suffixed with Endpoint and turn the public methods into actions
      //This will occur by default, only placed in here for understanding
      Actions.IncludeClassesSuffixedWithEndpoint();

      //Enables the Fubu3 Diagnostics - Very useful for troubleshooting your application (access via "localhost:port#/_fubu")
      Features.Diagnostics.Enable(TraceLevel.Verbose);
    }
  }
}