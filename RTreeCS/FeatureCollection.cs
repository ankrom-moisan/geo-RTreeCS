﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTreeCS
{
    class FeatureCollection
    {
        public GeoType type { get; set; }
        public IList<Feature> features { get; set; }
    }
}
