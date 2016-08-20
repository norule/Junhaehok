using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Junhaehok
{
	public struct CFSignupRequest
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public char[] user;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
        public char[] password;
	}

    public struct CFDeleteUserRequest
	{
	}

    public struct CFUpdateUserRequest
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
        public char[] password;
	}

    public struct CFDummySigninRequest
	{
	}

    public struct CFSigninRequest
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public char[] user;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
        public char[] password;
	}

    public struct CFSignoutRequest
	{
	}
}
