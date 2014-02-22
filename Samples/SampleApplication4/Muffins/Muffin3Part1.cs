﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MuffinFramework.Muffin;

namespace SampleApplication4.Muffins
{
    public class Muffin3Part1 : MuffinPart<Muffin3.Protocol>
    {
        protected override void Enable()
        {
            // This will call Protocol.HelloWorld which will then invoke Muffin3.HelloWorld
            Host.HelloWorld();
        }
    }
}
