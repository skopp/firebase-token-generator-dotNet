﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Firebase
{
    public class TokenOptions
    {
        public DateTime? expires { get; private set; }
        public DateTime? notBefore { get; private set; }
        public bool admin { get; private set; }
        public bool debug { get; private set; }

        /// <summary>
        /// Constructor.  All options are optional.
        /// </summary>
        /// <param name="notBefore">The date/time at which the token should no longer be considered valid. (default is never)</param>
        /// <param name="expires">The date/time before which the token should not be considered valid. (default is now)</param>
        /// <param name="admin">Set to true to bypass all security rules (you can use this for trusted server code).</param>
        /// <param name="debug">Set to true to enable debug mode (so you can see the results of Rules API operations).</param>
        public TokenOptions(DateTime? notBefore = null, DateTime? expires = null, bool admin = false, bool debug = false)
        {
            this.notBefore = notBefore;
            this.expires = expires;
            this.admin = admin;
            this.debug = debug;
        }
    }
}
