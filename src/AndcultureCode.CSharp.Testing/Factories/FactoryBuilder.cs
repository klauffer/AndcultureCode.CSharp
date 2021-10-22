using System;

namespace AndcultureCode.CSharp.Testing.Factories
{
    internal class FactoryBuilder
    {
        public Factory      Factory       { get; set; }
        public Func<object> BuildCallback { get; set; }
    }
}