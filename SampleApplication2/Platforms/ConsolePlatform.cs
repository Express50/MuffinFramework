﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuffinFramework.Platform;

namespace SampleApplication2.Platforms
{
    public class ConsolePlatform : Platform
    {
        protected override void Enable()
        {
            // Nothing to do here...
        }

        public event EventHandler<string> OutputRecieved;

        public void WriteLine(string text)
        {
            // We call the OutputRecieved event here, this will be used by LogMuffin
            // to get informed of new console outputs.
            EventHandler<string> handler = OutputRecieved;
            if (handler != null) 
                handler(this, text);


            // Write the recieved text to the console.
            Console.WriteLine(text);
        }
    }
}
