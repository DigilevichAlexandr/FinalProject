﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace IfItFits
{
    public class DiggisHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}