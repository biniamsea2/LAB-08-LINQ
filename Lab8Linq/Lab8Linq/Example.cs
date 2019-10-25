using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8Linq
{
    class Example
    {
        public string Type { get; set; }
        public IList<Feature> Features { get; set; }

        public Example(string type, IList<Feature> features)
        {
            Type = type;
            Features = features;
        }

     

    }



}
