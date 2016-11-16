using Nancy;
using System.Collections.Generic;

namespace EnterNamespaceHere //replace with your desired namespace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      //Insert your GETs and POSTs here
    }
  }
}
