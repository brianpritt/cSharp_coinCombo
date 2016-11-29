using Nancy;
using System.Collections.Generic;
using Coins.Objects;

namespace Coins //replace with your desired namespace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];

      Post["/submit"] = _ => {
          int changeValue = Request.Form["change-value"];
          Coin newCoin = new Coin(changeValue);
          Dictionary<string, int> resultingChange = newCoin.MakeChange();
          return View["change.cshtml", resultingChange];
      };
    }
  }
}
