using System;
using System.Collections.Generic;
using System.Linq;

namespace PerformanceCryptographyAlgorithms.Helpers
{
    public class CloneableList<T> : List<T>, ICloneable 
    {
        public object Clone()
        {
            var clone = new CloneableList<T>();
            clone.AddRange(this);
            return clone;
        }
    }
}
