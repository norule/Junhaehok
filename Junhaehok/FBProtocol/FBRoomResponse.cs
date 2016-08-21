using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Junhaehok
{
    public struct FBRoomCreateResponse
    {
        public int roomNum;
    }

    public struct FBRoomListResponse
    {
    }

    public struct FBRoomJoinResponse
    {
    }

    public struct FBRoomLeaveResponse
    {
    }

    public struct FBRoomJoinRedirectResponse
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public char[] ip;
        public int port;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] cookie;
    }
}
