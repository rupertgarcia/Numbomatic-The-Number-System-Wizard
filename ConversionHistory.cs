using System;
using System.Collections.Generic;

namespace MyNameSpace
{
    public class ConversionHistory
    {
        private List<ConversionEntry> conversions;

        public ConversionHistory()
        {
            conversions = new List<ConversionEntry>();
        }

        public void AddConversion(int originalValue, int convertedValue)
        {
            ConversionEntry entry = new ConversionEntry
            {
                OriginalValue = originalValue,
                ConvertedValue = convertedValue,
                DateTime = DateTime.Now
            };

            conversions.Add(entry);
        }

        public List<ConversionEntry> GetConversions()
        {
            return conversions;
        }

        public bool IsEmpty()
        {
            return conversions.Count == 0;
        }
    }

    public class ConversionEntry
    {
        public int OriginalValue { get; set; }
        public int ConvertedValue { get; set; }
        public DateTime DateTime { get; set; }
    }
}
