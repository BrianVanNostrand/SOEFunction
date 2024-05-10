using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SOEFunctionalityTest.Utils;

namespace SOEFunctionalityTest.Models
{
    public class SOEResponseModel : ObservableObject
    {
        private double _angle = 0;
        public double Angle
        {
            get { return _angle; }
            set
            {
                _angle = value;
                OnPropertyChanged("Angle");
            }
        }

        private double _arm = 10;
        public double Arm
        {
            get { return _arm; }
            set
            {
                _arm = value;
                OnPropertyChanged("ARM");
            }
        }

        private bool _back = false;
        public bool Back
        {
            get { return _back; }
            set
            {
                _back = value;
                OnPropertyChanged("Back");
            }
        }

        private bool _decrease = false;

        public bool Decrease
        {
            get { return _decrease; }
            set
            {
                _decrease = value;
                OnPropertyChanged("Decrease");
            }
        }

        private double _distance = 0;

        public double Distance
        {
            get { return _distance; }
            set
            {
                _distance = value;
                OnPropertyChanged("Distance");
            }
        }

        private string? _route = "null";

        public string? Route
        {
            get { return _route; }
            set
            {
                _route = value;
                OnPropertyChanged("Route");
            }
        }

        private double _srmp = 0;

        public double Srmp
        {
            get { return _srmp; }
            set
            {
                _srmp = value;
                OnPropertyChanged("SRMP");
            }
        }
        private coordinatePair? _eventPoint;
        public coordinatePair? EventPoint {
            get { return _eventPoint; }
            set
            {
                _eventPoint = value;
                OnPropertyChanged("EventPoint");
            }
        }
        public class coordinatePair
        {
            public double x { get; set; }
            public double y { get; set; }
        }
    }
}
