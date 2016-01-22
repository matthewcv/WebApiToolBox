using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostedApi
{
    public class StuffController:ApiController
    {
        public List<Stuff> Get()
        {
            return new List<Stuff>()
            {
                new Stuff()
            };
        }
        public Stuff Get(string id)
        {
            return new Stuff();
        }

        public Stuff Post(Stuff stuff)
        {
            return stuff;
        }

    }

    public class Stuff
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public int HowManyTacosCanYouEat { get; set; }
    }
}
