using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryEx1.ConcreteClasses
{
    public class MacDropDown : IDropDown
    {
        public void render()
        {
            Console.WriteLine("Renderizando un Dropdown para Mac");
        }
    }
}
