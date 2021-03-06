﻿namespace V8ChromeDebugEngine.Events
{
    using System;

    public sealed class MessageEventArgs : EventArgs
    {
        public MessageEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}