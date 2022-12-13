﻿using System.Runtime.Serialization;

namespace Trakttv.TraktAPI.Model
{
    [DataContract]
    public class TraktEpisode
    {
        [DataMember(Name = "season")]
        public int Season { get; set; }

        [DataMember(Name = "number")]
        public int Number { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "ids")]
        public TraktEpisodeId Ids { get; set; }
    }
}
