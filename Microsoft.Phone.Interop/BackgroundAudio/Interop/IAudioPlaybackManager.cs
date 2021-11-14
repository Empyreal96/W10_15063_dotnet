// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundAudio.Interop.IAudioPlaybackManager
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System.Runtime.InteropServices;

namespace Microsoft.Phone.BackgroundAudio.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("7418D1C4-DDB1-4f38-AC55-FDFD6E7ED0BD")]
  [ComImport]
  internal interface IAudioPlaybackManager
  {
    void Initialize(uint taskId);

    void Close();

    void Clear();

    void FastForward();

    void Pause();

    void Play();

    void Stop();

    void Rewind();

    void SkipNext();

    void SkipPrevious();

    IAudioTrack CurrentTrack { get; set; }

    int CurrentPosition { get; set; }

    uint PlayState { get; }

    double Volume { get; set; }

    bool CanPause { get; }

    bool CanSeek { get; }

    IAudioPlaybackManagerCallback EventCallback { get; set; }

    uint BufferingProgress { get; }
  }
}
