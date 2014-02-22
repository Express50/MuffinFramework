﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuffinFramework
{
    public abstract class LayerPart<TProtocol, TArgs> : LayerBase<TArgs>, ILayerPart<TProtocol, TArgs>
    {
        private readonly object _lockObj = new object();

        public TProtocol Host { get; private set; }
        public void Enable(TProtocol host, TArgs args)
        {
            lock (_lockObj)
            {
                if (IsEnabled)
                    throw new InvalidOperationException("LayerPart has already been enabled.");

                Host = host;

                Enable(args);
            }
        }

        protected TPart EnablePart<TPart>(TProtocol host) where TPart : class, ILayerPart<TProtocol, TArgs>, new()
        {
            return EnablePart<TPart, TProtocol>(host);
        }

        protected TPart EnablePart<TPart>() where TPart : class, ILayerPart<TProtocol, TArgs>, new()
        {
            return EnablePart<TPart, TProtocol>();
        }
    }
}