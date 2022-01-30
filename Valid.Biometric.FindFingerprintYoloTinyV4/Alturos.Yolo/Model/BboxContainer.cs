using System.Runtime.InteropServices;
using Valid.Biometric.FindFingerprintYoloTinyV4;

namespace Alturos.Yolo.Model
{
    /// <summary>
    /// C++ Communication object
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct BboxContainer
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = FindFingerprintYoloTinyV4.MaxObjects)]
        internal BboxT[] candidates;
    }
}
