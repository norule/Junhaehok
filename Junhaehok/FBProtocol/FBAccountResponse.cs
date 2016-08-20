using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Junhaehok
{
    public struct FBSignupResponse
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] cookie;
    }
    public struct FBDeleteUserResponse
    {
    }
    public struct FBUpdateUserResponse
    {
    }

    public struct FBDummySigninResponse
    {
    }
    //Login and ConnectPassing
    public struct FBSigninResponse
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public char[] ip;
        public int port;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] cookie;
    }

    public struct FBSignoutResponse
    {
    }
}
