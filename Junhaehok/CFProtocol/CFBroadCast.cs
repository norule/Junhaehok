using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Junhaehok
{
    public struct CFBroadCast
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public char[] userName;
        //data[]
    }
}
