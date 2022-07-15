using System.Runtime.InteropServices;

namespace DebugReader
{
    public static class ExtDebugClient
    {
        [DllImport("DebugClient.dll")]
        public static extern int Intialize();
        
        [DllImport("DebugClient.dll")]
        public static extern int Terminate();
        
        [DllImport("DebugClient.dll")]
        public static extern string GetData();
    }
}