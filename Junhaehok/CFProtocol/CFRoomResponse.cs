using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Junhaehok
{
    public struct CFRoomCreateResponse
    {
        public int roomNum;
    }

    public struct CFRoomListResponse
    {
    }

    public struct CFRoomJoinResponse
    {
    }

    public struct CFRoomLeaveResponse
    {
    }

    public struct CFRoomJoinRedirectResponse
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public char[] ip;
        public int port;
    }
}
