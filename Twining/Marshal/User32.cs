namespace Twining.Marshal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;

    public static class User32
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(ref Win32Point pt);

        [StructLayout(LayoutKind.Sequential)]
        private struct Win32Point
        {
            public Int32 x;
            public Int32 y;
        }

        public static Point GetMousePosition()
        {
            Win32Point point = new Win32Point();
            GetCursorPos(ref point);
            return new Point(point.x, point.y);
        }
    }
}
