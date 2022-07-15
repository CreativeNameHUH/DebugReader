using System.Runtime.InteropServices;

namespace DebugReader
{
    public static class ExtDebugClient
    {
        [DllImport("DebugClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Initialize();
        
        [DllImport("DebugClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Terminate();
        
        [DllImport("DebugClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern string GetData();
    }
}