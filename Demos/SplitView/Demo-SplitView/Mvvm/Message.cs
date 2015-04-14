using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Navigation;

namespace Template10.Mvvm
{
    // message is a generic implementation of imessage
    public class Message<T> : IMessage
    {
        public T Payload
        {
            get;
            set;
        }
    }
}