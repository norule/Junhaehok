using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Junhaehok
{
    public struct FBRoomCreateRequest
    {
    }

    public struct FBRoomListRequest
    {
    }

    public struct FBRoomJoinRequest
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] cookie;
        public int roomNum;
    }

    public struct FBRoomLeaveRequest
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] cookie;
    }
}
