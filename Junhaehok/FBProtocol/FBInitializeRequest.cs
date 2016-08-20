using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Junhaehok
{
    public struct FBInitializeRequest
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public char[] cookie;
    }
}
