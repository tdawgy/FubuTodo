﻿using FubuMVC.Core.Registration;

namespace FubuTodo
{
  public class CoreRegistry : ServiceRegistry
  {
    public CoreRegistry()
    {
      Scan(x =>
      {
        //scans the calling assembly for items to automatically add to the container that follow the default conventions
        //the main one to take note of is 'Fubu is IFubu'
        x.TheCallingAssembly();
        x.WithDefaultConventions();
      });
    }
  }
}