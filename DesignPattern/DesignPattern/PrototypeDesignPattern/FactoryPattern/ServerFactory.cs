using CsvHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPattern
{
    public abstract class ServerFactory
    {
        public abstract IFactory GetFactory(string company);
    }
}
