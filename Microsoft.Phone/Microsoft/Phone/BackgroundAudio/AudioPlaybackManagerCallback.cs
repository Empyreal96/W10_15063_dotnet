// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundAudio.AudioPlaybackManagerCallback
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.BackgroundAudio.Interop;
using System;
using System.Windows;

namespace Microsoft.Phone.BackgroundAudio
{
  internal class AudioPlaybackManagerCallback : IAudioPlaybackManagerCallback
  {
    void IAudioPlaybackManagerCallback.PlayStateChanged(
      uint NewPlayState)
    {
      uint num = 2147483648;
      bool fIsAPlayStateChangedEvent = false;
      try
      {
        if (((int) num & (int) NewPlayState) == (int) num)
        {
          fIsAPlayStateChangedEvent = true;
          NewPlayState &= (uint) byte.MaxValue;
        }
        BackgroundAudioPlayer.Instance.HandlePlayStateChanged((PlayState) NewPlayState, fIsAPlayStateChangedEvent);
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    void IAudioPlaybackManagerCallback.CriticalError(uint hr)
    {
      try
      {
        BackgroundAudioPlayer.Instance.HandleCriticalError((int) hr);
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }
  }
}
