using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Junhaehok
{
    public struct CFSignupResponse
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] cookie;
    }
    public struct CFDeleteUserResponse
    {
    }
    public struct CFUpdateUserResponse
    {
    }

    public struct CFDummySigninResponse
    {
    }
    //Login and ConnectPassing
    public struct CFSigninResponse
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public char[] ip;
        public int port;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] cookie;
    }

    public struct CFSignoutResponse
    {
    }
}
