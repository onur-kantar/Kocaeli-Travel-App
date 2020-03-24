using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocaeli_Travel_App
{
    public class Armchair
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string State { get; set; }
        public string Price { get; set; }

        public Armchair(string id, string name, string gender, string state, string price)
        {
            Id = id;
            Price = price;
            Name = name;
            Gender = gender;
            State = state;
        }
    }
}
