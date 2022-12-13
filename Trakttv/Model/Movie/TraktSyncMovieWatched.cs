﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Trakttv.TraktAPI.Model
{
    [DataContract]
    public class TraktSyncMovieWatched : TraktMovie
    {
        [DataMember(Name = "watched_at")]
        public string WatchedAt { get; set; }
    }
}
