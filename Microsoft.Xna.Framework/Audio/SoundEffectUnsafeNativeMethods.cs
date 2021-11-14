// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Audio.SoundEffectUnsafeNativeMethods
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.Audio
{
  [SecurityCritical]
  internal static class SoundEffectUnsafeNativeMethods
  {
    private const string XnaFrameworkCoreDll = "XnaFrameworkCore";

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes ShutdownAudioEngine();

    [DllImport("XnaFrameworkCore")]
    internal static extern unsafe ErrorCodes CreateSoundEffectHandle(
      byte* format,
      uint formatSizeBytes,
      byte* data,
      uint dataLength,
      uint* kernelSoundEffectHandle);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes ReleaseSoundEffectHandle(
      uint kernelSoundEffectHandle);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes SetMasterVolume(float volume);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes GetMasterVolume(ref float volume);

    [DllImport("XnaFrameworkCore")]
    internal static extern unsafe ErrorCodes CreateSoundEffectInstance(
      uint soundEffectHandle,
      uint* soundEffectInstanceHandle);

    [DllImport("XnaFrameworkCore")]
    internal static extern unsafe ErrorCodes CreateDynamicSoundEffectInstance(
      byte* format,
      uint formatSizeBytes,
      uint* soundEffectInstanceHandle);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes DestroySoundEffectInstance(
      uint soundEffectInstanceHandleHandle);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes SubmitPacket(
      uint soundEffectInstanceHandle,
      int loopStart,
      int loopLength,
      int loopCount);

    [DllImport("XnaFrameworkCore")]
    internal static extern unsafe ErrorCodes SubmitBuffer(
      uint soundEffectInstanceHandle,
      byte* data,
      uint size);

    [DllImport("XnaFrameworkCore")]
    internal static extern unsafe ErrorCodes GetPendingBufferCount(
      uint soundEffectInstanceHandle,
      int* count);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes Play(uint handle);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes Stop(uint handle, bool immediate);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes Pause(uint handle);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes SetVolume(uint handle, float volume);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes SetPitch(uint handle, float pitch);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes SetPan(uint handle, float pan);

    [DllImport("XnaFrameworkCore")]
    internal static extern ErrorCodes GetState(uint handle, ref VoiceState state);
  }
}
