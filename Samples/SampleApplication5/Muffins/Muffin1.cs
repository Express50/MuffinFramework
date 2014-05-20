﻿using System;
using MuffinFramework.Muffins;
using SampleApplication1.Platforms;

namespace SampleApplication5.Muffins
{
    public class Muffin1 : Muffin
    {
        protected override void Enable()
        {
            var hostPlatform = this.PlatformLoader.Get<HostPlatform>();
            string[] args = hostPlatform.GetArgsCallback();

            Console.WriteLine("Commandline arguemnts: " + string.Join(" ", args));
        }
    }
}