using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Junhaehok
{
    public struct FBAdvertiseRequest
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public char[] ip;
        public int port;
    }
}
