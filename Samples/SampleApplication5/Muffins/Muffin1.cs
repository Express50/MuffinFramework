﻿using System;
using MuffinFramework.Muffins;
using SampleApplication5.Platforms;

namespace SampleApplication5.Muffins
{
    public class Muffin1 : Muffin
    {
        protected override void Enable()
        {
            var hostPlatform = this.PlatformLoader.Get<HostPlatform>();
            var args = hostPlatform.GetArgsCallback();

            Console.WriteLine("Commandline arguemnts: " + string.Join(" ", args));
        }
    }
}
