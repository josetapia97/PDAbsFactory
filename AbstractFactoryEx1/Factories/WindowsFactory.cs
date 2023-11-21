using AbstractFactoryEx1.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryEx1.Factories
{
    internal class WindowsFactory : IThemeFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public IDropDown CreateDropDown()
        {
            return new WindowsDropDown();
        }

        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }
}
