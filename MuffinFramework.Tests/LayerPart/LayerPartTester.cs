﻿namespace MuffinFramework.Tests.LayerPart
{
    internal class LayerPartTester<TProtocol, TArgs> : LayerPart<TProtocol, TArgs>
    {
        public TProtocol TestHost
        {
            get { return this.Host; }
        }

        public bool EnableWasCalled;

        protected override void Enable()
        {
            this.EnableWasCalled = true;
        }

        public TPart TestEnablePart<TPart>(TProtocol host) where TPart : class, ILayerPart<TProtocol, TArgs>, new()
        {
            return this.EnablePart<TPart>(host);
        }

        public TPart TestEnablePart<TPart>() where TPart : class, ILayerPart<TProtocol, TArgs>, new()
        {
            return this.EnablePart<TPart>();
        }
    }

    // A LayerPartTester that has itself as its Protocol
    class LayerPartTester2<TArgs> : LayerPartTester<LayerPartTester2<TArgs>, TArgs>
    {

    }
}
