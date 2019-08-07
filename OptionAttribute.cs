using System;

namespace Idea
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class OptionAttribute : Attribute
    {
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public bool HasValue { get; set; }
        public string Tip { get; set; }

        public OptionAttribute(string shortName, string longName, bool hasValue, string tip)
        {
            if( shortName == null && longName == null)
            {
                throw new ArgumentNullException("No value for any of the options");
            }

            ShortName = shortName;
            LongName = longName;
            HasValue = hasValue;
            Tip = tip;

            ShortName = $"-{ShortName}";
            LongName = $"--{LongName}";
        }
    }
}
