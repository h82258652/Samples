﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace ApiInformationDemo.Services
{
    public class NavigationEventArgs : EventArgs
    {
        public NavigationMode NavigationMode { get; set; }
        public string Parameter { get; set; }
    }
}
