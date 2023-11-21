using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryEx1
{
    public interface IButton
    {
        //cualquier clase que extienda IButton tiene que implementar render
        void render();
    }
}
