using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8Linq
{
    class Feature
    {
        public string Type { get; set; }
        public Geometry Geometry { get; set; }
        public Properties Properties { get; set; }

        public Feature(string type, Geometry geometry, Properties properties)
        {
            Type = type;
            Geometry = geometry;
            Properties = properties;
        }

    }
}
