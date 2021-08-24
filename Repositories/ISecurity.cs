using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ISecurity<T>
    {
        public T Check(string mail, string password);
    }
}
