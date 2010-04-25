using System.Configuration;

namespace RSSTray
{
    public class RSSFeedConfiguration : ConfigurationSection
    {
        private static readonly ConfigurationProperty toAttribute =
             new ConfigurationProperty("To", typeof(string), string.Empty, ConfigurationPropertyOptions.IsRequired);

        private static readonly ConfigurationProperty fromAttribute =
             new ConfigurationProperty("From", typeof(string), string.Empty, ConfigurationPropertyOptions.IsRequired);


        private static readonly ConfigurationProperty RSSFeedsElement =
             new ConfigurationProperty("RSSFeeds", typeof(RSSFeedCollection), null, ConfigurationPropertyOptions.IsRequired);

        public RSSFeedConfiguration()
        {
            base.Properties.Add(toAttribute);
            base.Properties.Add(fromAttribute);
            base.Properties.Add(RSSFeedsElement);
        }

        /// <summary>
        /// To
        /// </summary>
        [ConfigurationProperty("To", IsRequired = true)]
        public string To
        {
            get { return (string)this[toAttribute]; }
        }

        /// <summary>
        /// From
        /// </summary>
        [ConfigurationProperty("From", IsRequired = true)]
        public string From
        {
            get { return (string)this[fromAttribute]; }
        }

        /// <summary>
        /// RSSFeeds Collection
        /// </summary>
        [ConfigurationProperty("RSSFeeds", IsRequired = true)]
        public RSSFeedCollection RSSFeeds
        {
            get { return (RSSFeedCollection)this[RSSFeedsElement]; }
        }
    }



    /// <summary>
    /// Class holds the <Message> element
    /// </summary>
    public class RSSFeedsElement : ConfigurationElement
    {
        // Holds the feedName attribute of the RSSFeeds
        private static readonly ConfigurationProperty feedName =
            new ConfigurationProperty("feedName", typeof(string), string.Empty, ConfigurationPropertyOptions.IsRequired);

        // Holds the feedURL attribute value of RSSFeeds.
        private static readonly ConfigurationProperty feedURL =
            new ConfigurationProperty("feedURL", typeof(string), string.Empty, ConfigurationPropertyOptions.IsRequired);

        // Holds the refresh  attribute value of RSSFeeds.
        private static readonly ConfigurationProperty refresh =
            new ConfigurationProperty("refresh", typeof(string), string.Empty, ConfigurationPropertyOptions.IsRequired);

        public RSSFeedsElement()
        {
            base.Properties.Add(feedName);
            base.Properties.Add(feedURL);
            base.Properties.Add(refresh);
        }

        /// <summary>
        /// Name
        /// </summary>
        [ConfigurationProperty("feedName", IsRequired = true)]
        public string FeedName
        {
            get { return (string)this[feedName]; }
        }

        /// <summary>
        /// Value
        /// </summary>
        [ConfigurationProperty("feedURL", IsRequired = true)]
        public string FeedURL
        {
            get { return (string)this[feedURL]; }
        }
    }



    [ConfigurationCollection(typeof(RSSFeedsElement), AddItemName = "Feed",
         CollectionType = ConfigurationElementCollectionType.BasicMap)]
    public class RSSFeedCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new RSSFeedsElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((RSSFeedsElement)element).FeedName;
        }

        new public RSSFeedsElement this[string name]
        {
            get { return (RSSFeedsElement)BaseGet(name); }
        }

        new public RSSFeedsElement this[int i]
        {
            get { return (RSSFeedsElement)BaseGet(i); }
        }
    }

}
