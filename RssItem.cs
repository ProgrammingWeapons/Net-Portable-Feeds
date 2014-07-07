﻿using System;
using System.Collections.Generic;

namespace ProgrammingWeapons.Feeds
{
    public class RssItem : IRssItem
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public DateTime PubDate { get; set; }
        public string Guid { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }

        public List<IRssTag> Tags { get; set; }


        public RssItem() {
            Tags = new List<IRssTag>();
        }
    }
}