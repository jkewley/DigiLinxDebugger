using System.Configuration;
using System.Text.RegularExpressions;
using System.Xml;

namespace NetStreamsDebugger.Support {
    public class Filter {
        private string aName;
        private bool anExclude;
        private bool anInclude;
        private string aPattern;
        private Regex aRegularExpression;

        public Filter() {}

        public Filter(string aFilterName, string aRegexPattern, bool aExclude, bool aInclude) {
            aName = aFilterName;
            aPattern = aRegexPattern;
            anExclude = aExclude;
            anInclude = aInclude;
        }

        public bool Include { get { return anInclude; } set { anInclude = value; } }
        public bool Exclude { get { return anExclude; } set { anExclude = value; } }
        public string Name { get { return aName; } set { aName = value; } }

        public string Pattern {
            get { return aPattern; }
            set {
                aPattern = value;
                aRegularExpression = new Regex(aPattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
            }
        }

        public Regex RegularExpression {
            get {
                if(aRegularExpression == null)
                    aRegularExpression = new Regex(aPattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
                return aRegularExpression;
            }
        }
    }

    public class SavedFilter : ConfigurationElement {
        public SavedFilter() {}

        [ConfigurationProperty("Name", IsKey = true)]
        public string Name { get { return (string) this["Name"]; } set { this["Name"] = value; } }

        [ConfigurationProperty("Pattern")]
        public string Pattern { get { return (string) this["Pattern"]; } set { this["Pattern"] = value; } }

        [ConfigurationProperty("Include")]
        public bool Include { get { return (bool) this["Include"]; } set { this["Include"] = value; } }

        [ConfigurationProperty("Exclude")]
        public bool Exclude { get { return (bool) this["Exclude"]; } set { this["Exclude"] = value; } }
    }

    public class FiltersConfigurationSection : ConfigurationSection {
        [ConfigurationProperty("Filters", IsDefaultCollection = true)]
        public FiltersCollection Filters { get { return (FiltersCollection) (base["Filters"]); } }

        protected override bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader) {
            // This is a useful method to break on in the debugger because it lets you know what the configuration reader is up to.
            return base.OnDeserializeUnrecognizedElement(elementName, reader);
        }
    }

    /// <summary>
    /// The collection class that will store the list of each element/item that
    ///        is returned back from the configuration manager.
    /// </summary>
    [ConfigurationCollection(typeof(Filter))]
    public class FiltersCollection : ConfigurationElementCollection {
        public SavedFilter this[int index] { get { return (SavedFilter) BaseGet(index); } }

        public new SavedFilter this[string key] { get { return (SavedFilter) BaseGet(key); } }

        protected override ConfigurationElement CreateNewElement() {
            return new SavedFilter();
        }

        protected override bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader) {
            // This is a useful method to break on in the debugger because it lets you know what the configuration reader is up to.
            return base.OnDeserializeUnrecognizedElement(elementName, reader);
        }

        public void Add(SavedFilter element) {
            BaseAdd(element);
        }

        public void Add(Filter element) {
            SavedFilter aFilter = new SavedFilter();
            aFilter.Name = element.Name;
            aFilter.Pattern = element.Pattern;
            aFilter.Exclude = element.Exclude;
            aFilter.Include = element.Include;
            BaseAdd(aFilter);
        }

        public void Remove(string key) {
            BaseRemove(key);
        }

        public void Clear() {
            BaseClear();
        }

        protected override object GetElementKey(ConfigurationElement element) {
            return ((SavedFilter) (element)).Name;
        }
    }
}