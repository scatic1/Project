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
        private bool _isNew = true;
        public bool IsNew
        {
            get => _isNew;
            set
            {
                if (_isNew != value)
                    _isNew = value;
            }
        }
        public bool IsOld
        {
            get => !_isNew;
            set
            {
                value = !_isNew;
            }
        }
        private bool _allreadyUsed = true;
        public bool AllreadyUsed
        {
            get => _allreadyUsed;
            set
            {
                if (_allreadyUsed != value)
                    _allreadyUsed = value;
            }
        }
        public bool DidntUsed
        {
            get => !AllreadyUsed;
            set
            {
                value = !AllreadyUsed;
            }
        }
        public string Profession { get; set; }
        public string Education { get; set; }
        public string Rate { get; set; }

        public bool NonAv
        {
            get => !Availability;
            set
            {
                value = !Availability;
            }
        }
        public double Star{ get; set; }

        public DateTime NextAvailabil { get; set; }

        public string[] Experience { get; set; }
        public string About { get; set; }
        public string SpiritAnimal { get; set; }
        public int YearsExperience { get; set; }

    }
}
