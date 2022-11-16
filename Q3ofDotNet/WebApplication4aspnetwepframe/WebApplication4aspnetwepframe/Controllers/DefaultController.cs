using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4aspnetwepframe.Controllers
{
    
    public class DefaultController : ApiController
    {
        double num1 = 6;
        double num2 = 7;

        [HttpGet]
        [Route("add")]
        public double Add()
        {
            return new ClassLibrary1FrameWork.Class1().Add(num1, num2);
        }

        [HttpGet]
        [Route("sub")]
        public double Sub()
        {
            return new ClassLibrary1FrameWork.Class1().Sub(num1, num2);
        }

        [HttpGet]
        [Route("mul")]
        public double Div()
        {
            return new ClassLibrary1FrameWork.Class1().Mul(num1, num2);
        }

        [HttpGet]
        [Route("div")]
        public double Mul()
        {
            return new ClassLibrary1FrameWork.Class1().Div(num1, num2);
        }
    }
}
