using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8Linq
{
    class Geometry
    {
        public string Type { get; set; }
        public IList<double> Coordinates { get; set; }
        public Geometry(string type, IList<double> coordinates)
        {
            Type = type;
            Coordinates = coordinates;
        }

    }
}
