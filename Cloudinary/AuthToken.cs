﻿using CloudinaryShared.Core;
using Cloudinary.NetCoreShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace CloudinaryDotNet
{
    public class AuthToken : AuthTokenBase
    {
        public AuthToken() : base() { }

        public AuthToken(string key) : base(key) { }

        protected override string EncodedUrl(string url)
        {
            return HttpUtility.UrlEncode(url, Encoding.UTF8);
        }
    }
}