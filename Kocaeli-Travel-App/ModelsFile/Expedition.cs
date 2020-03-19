using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocaeli_Travel_App
{
    public class Expedition
    {
        public string Id { get; set; }
        public string Road { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Capacity { get; set; }
        public string Price { get; set; }
        public string LicencePlate { get; set; }
        public string Captain { get; set; }

        public MyList<Armchair> Armchairs = new MyList<Armchair>();

        public Expedition(string id, string road, string date, string time, string capacity, string price, string licencePlate, string captain)
        {
            Id = id;
            Road = road;
            Date = date;
            Time = time;
            Capacity = capacity;
            Price = price;
            LicencePlate = licencePlate;
            Captain = captain;
        }
        public Expedition()
        {

        }
    }
}
