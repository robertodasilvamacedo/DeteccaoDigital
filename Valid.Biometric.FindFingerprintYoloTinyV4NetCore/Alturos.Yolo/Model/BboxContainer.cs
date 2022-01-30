using System.Runtime.InteropServices;
using Valid.Biometric.FindFingerprintYoloTinyV4NetCore;

namespace Alturos.Yolo.Model
{
    /// <summary>
    /// C++ Communication object
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct BboxContainer
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = FindFingerprintYoloTinyV4NetCore.MaxObjects)]
        internal BboxT[] candidates;
    }
}
