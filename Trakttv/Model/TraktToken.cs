﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Trakttv.TraktAPI.Model
{
    [DataContract]
    public class TraktToken
    {
        [DataMember(Name = "token")]
        public string Token { get; set; }
    }
}
