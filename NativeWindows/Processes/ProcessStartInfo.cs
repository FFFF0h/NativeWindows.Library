﻿using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace NativeWindows.Processes
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public class ProcessStartInfo : IDisposable
	{
		public int cb = Marshal.SizeOf(typeof(ProcessStartInfo));
		private string Reserved;
		public string Desktop;
		public string Title;
		public int X;
		public int Y;
		public int XSize;
		public int YSize;
		public int XCountChars;
		public int YCountChars;
		public int FillAttribute;
		public ProcessStartInfoFlags Flags;
		public ushort ShowWindow;
		private ushort Reserved2;
		private byte Reserved3;
		public SafeFileHandle StdInput = new SafeFileHandle(IntPtr.Zero, false);
		public SafeFileHandle StdOutput = new SafeFileHandle(IntPtr.Zero, false);
		public SafeFileHandle StdError = new SafeFileHandle(IntPtr.Zero, false);

		public void Dispose()
		{
			if (StdInput != null)
			{
				StdInput.Dispose();
			}
			if (StdOutput != null)
			{
				StdOutput.Dispose();
			}
			if (StdError != null)
			{
				StdError.Dispose();
			}
		}
	}
}
