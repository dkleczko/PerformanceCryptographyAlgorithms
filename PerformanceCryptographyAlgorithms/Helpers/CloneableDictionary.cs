using System;
using System.Collections.Generic;

namespace PerformanceCryptographyAlgorithms.Helpers
{
    public class CloneableDictionary<TKey, TValue> : Dictionary<TKey, TValue> where TValue : ICloneable
    {
        public CloneableDictionary<TKey, TValue> Clone()
        {
            var clone = new CloneableDictionary<TKey, TValue>();
            foreach (var kvp in this)
            {
                clone.Add(kvp.Key, (TValue)kvp.Value.Clone());
            }
            return clone;
        }
    }
}
