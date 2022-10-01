using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.HomeDog
{
    public interface IHomeDog
    {
        string NickName { get; }
        void Voice();
        void Sleep();
    }
}
