using System.Runtime.InteropServices;

namespace DLLTestApp
{
    public static class ExtDebugServer
    {
        [DllImport("DebugServer.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Initialize();
        
        [DllImport("DebugServer.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Terminate();
        
        [DllImport("DebugServer.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SendData(string data, int dataLength);
    }
}