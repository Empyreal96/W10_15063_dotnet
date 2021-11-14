// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Audio.MicrophoneUnsafeNativeMethods
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Xna.Framework.Audio
{
  [SecurityCritical]
  internal static class MicrophoneUnsafeNativeMethods
  {
    private const string XnaFrameworkCoreDll = "XnaFrameworkCore";

    [DllImport("XnaFrameworkCore")]
    internal static extern void ShutdownCaptureEngine();

    [DllImport("XnaFrameworkCore")]
    internal static extern unsafe ErrorCodes CreateMicrophone(int index, uint* handle);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes DestroyMicrophone(uint handle);

    [DllImport("XnaFrameworkCore")]
    internal static extern unsafe ErrorCodes GetMicrophoneCount(int* count);

    [DllImport("XnaFrameworkCore", EntryPoint = "StartMicrophone")]
    internal static extern ErrorCodes Start(uint handle);

    [DllImport("XnaFrameworkCore", EntryPoint = "StopMicrophone")]
    internal static extern ErrorCodes Stop(uint handle);

    [DllImport("XnaFrameworkCore")]
    internal static extern unsafe ErrorCodes GetData(
      uint handle,
      byte* data,
      int size,
      int* recorded);

    [DllImport("XnaFrameworkCore", EntryPoint = "GetMicrophoneState")]
    internal static extern ErrorCodes GetState(
      uint handle,
      ref MicrophoneCaptureState state);

    [DllImport("XnaFrameworkCore")]
    internal static extern unsafe ErrorCodes GetSampleRate(uint handle, int* sampleRate);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes GetName(uint handle, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder sb, int nLength);

    [DllImport("XnaFrameworkCore")]
    internal static extern unsafe ErrorCodes GetCaptureBufferDuration(
      uint handle,
      int* pnDurationInMs);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes SetCaptureBufferDuration(
      uint handle,
      int nDurationInMs);
  }
}
