using System.Runtime.InteropServices;

namespace DLLTestApp
{ 
    public static class ExtDebugConnector
    {
        [DllImport("DebugConnector.dll")]
        public static extern void SetInt(int value);
        
        [DllImport("DebugConnector.dll")]
        public static extern int GetInt();
        
        [DllImport("DebugConnector.dll")]
        public static extern bool IsDataAvailable();
    }
}