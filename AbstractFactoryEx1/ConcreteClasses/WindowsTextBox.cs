using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryEx1.ConcreteClasses
{
    public class WindowsTextBox : ITextBox
    {
        public void render()
        {
            Console.WriteLine("Renderizando un textbox para Windows");
        }
    }
}
