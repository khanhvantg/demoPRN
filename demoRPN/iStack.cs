using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoRPN
{
    interface iStack<T>
    {
        void Push(T value);
        T Pop();
        T Peek();
    }
}
