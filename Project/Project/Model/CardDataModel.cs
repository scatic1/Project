using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public class CardDataModel
    {public  string ProfileImage { get; set; }
        public string Name { get; set; }
        private bool _availability=true;
        public bool Availability
        {
            get => _availability;
            set
            {
                if (_availability != value)
                    _availability = value;
            }
        }
        public string Profession { get; set; }
        public string Education { get; set; }
        public string Rate { get; set; }

        public bool NonAv
        {
            get => !_availability;
            set
            {
                value = !_availability;
            }
        }
        public double Star{ get; set; }
        //public List<string> Experience { get; set; }
       public  string[] Experience;
    }
}
