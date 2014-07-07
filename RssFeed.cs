using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ProgrammingWeapons.Feeds
{
    public abstract class RssFeed : PropertyChangedBase, IRssFeed
    {
        protected RssFeed(IList<IRssItem> items) {
            Items = items;
        }

        [Magic] public virtual string Title { get; set; }
        [Magic] public virtual string Url { get; set; }
        [Magic] public virtual string Link { get; set; }
        [Magic] public virtual string Generator { get; set; }
        [Magic] public virtual string Description { get; set; }
        [Magic] public virtual string Language { get; set; }
        [Magic] public virtual DateTime DateAdded { get; set; }

        [Magic] public virtual XElement Rss { get; set; }

        public virtual IRssItem AddItem() {
            var item = new RssItem();
            Items.Add(item);
            return item;
        }


        private DateTime? _pubDate;
        [Magic] public virtual DateTime PubDate {
            get {
                if (_pubDate != null) return _pubDate.Value;
                return Items.Count == 0 ? DateAdded : Items[0].PubDate;
            }
            set { _pubDate = value; }
        }

        public virtual IList<IRssItem> Items { get; set; }

    }
}