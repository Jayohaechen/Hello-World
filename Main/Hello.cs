using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Hello
    {

        public string hello { get; set; }

        public Hello(string hello)
        {
            this.hello = hello;
        }
        public string hEllo()
        {
            return hello;
        }
    }
}
