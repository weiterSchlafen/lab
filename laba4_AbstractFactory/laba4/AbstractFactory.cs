using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba4
{
    // "AbstractFactory" 

    public abstract class AbstractFactory
    {
        public abstract AbstractProperties CreateProperties();
        public abstract Form CreateWindow(AbstractProperties abstractProperties);
    }

    // "ConcreteFactory1" 

    public class Drevolaz : AbstractFactory
    {
        public override Form CreateWindow(AbstractProperties abstractProperties)
        {
            return new drevolazForm(abstractProperties);
        }

        public override AbstractProperties CreateProperties()
        {
            return new PropertiesDrevolaz();
        }
    }

    // "ConcreteFactory2" 

    public class Vodonos : AbstractFactory
    {
        public override Form CreateWindow(AbstractProperties abstractProperties)
        {
            return new vodonosForm(abstractProperties);
        }

        public override AbstractProperties CreateProperties()
        {
            return new PropertiesVodonos();
        }
    }

    class Client
    {
        private Form jaba;
        private AbstractProperties properties;

        public Client(AbstractFactory factory)
        {
            properties = factory.CreateProperties();
            jaba = factory.CreateWindow(properties);
        }

        public void Run()
        {
            jaba.ShowDialog();
        }
    }
}
