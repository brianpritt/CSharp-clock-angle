using Nancy;
using System;
using System.Collections.Generic;
using ClockAngle.Objects;

namespace ClockAngle
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get ["/"] = _ =>{
        return View["index.cshtml"];
      };
      Post["/results"] = _ =>{
        Clock newClock = new Clock(Request.Form["hour"], Request.Form["minute"]);
        float result = newClock.testFor180();
        return View["result.cshtml", result];
      };
    }
  }
}
