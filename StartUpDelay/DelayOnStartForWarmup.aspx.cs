﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StartUpDelay
{
    public partial class DelayOnStartForWarmup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(TimeSpan.FromMinutes(1));
        }
    }
}