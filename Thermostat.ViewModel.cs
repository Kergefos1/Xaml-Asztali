using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Thermostat
    {
        private string _devicename;
        private double _targetTemperature;
        private bool _maualview;

        public string Decivename { get { return _devicename; } set { _devicename = value; } }
        public double TargetTemperature { get { return _targetTemperature; } set { _targetTemperature = value; } }
        public bool Maualview { get { return _maualview; } set { _maualview = value; } }

        public Thermostat()
        {
            Decivename = "HomeTherm 200";
            TargetTemperature = 22.0;
            Maualview = false;
        }
    }
}
