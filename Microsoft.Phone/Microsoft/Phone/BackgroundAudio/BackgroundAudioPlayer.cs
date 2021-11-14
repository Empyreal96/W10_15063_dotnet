// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundAudio.BackgroundAudioPlayer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.BackgroundAudio.Interop;
using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;

namespace Microsoft.Phone.BackgroundAudio
{
  public sealed class BackgroundAudioPlayer
  {
    private AudioPlaybackManagerInterop _apmInterop;
    private IAudioPlaybackManager _IAudioPlaybackManager;
    private IAudioPlaybackManagerCallback _EventCallback;
    private AudioStreamer _streamer;
    private bool _isHeadless;
    private static uint _appId = 0;
    private static volatile BackgroundAudioPlayer _instance;
    private static object syncRoot = new object();
    private int _CriticalErrorCode;

    public static BackgroundAudioPlayer Instance
    {
      get
      {
        if (BackgroundAudioPlayer._instance == null)
        {
          lock (BackgroundAudioPlayer.syncRoot)
          {
            if (BackgroundAudioPlayer._instance == null)
            {
              BackgroundAudioPlayer._instance = new BackgroundAudioPlayer();
              BackgroundAudioPlayer._instance.Initialize();
            }
          }
        }
        return BackgroundAudioPlayer._instance;
      }
    }

    public PlayState PlayerState
    {
      get
      {
        try
        {
          return (PlayState) this._IAudioPlaybackManager.PlayState;
        }
        catch (COMException ex)
        {
          throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
        }
      }
    }

    public event EventHandler PlayStateChanged;

    public void Play()
    {
      try
      {
        if (this.IsMSSTrackSet())
          this._streamer.Play();
        else
          this._IAudioPlaybackManager.Play();
      }
      catch (COMException ex)
      {
        throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
      }
    }

    public void Pause()
    {
      try
      {
        if (this.IsMSSTrackSet())
          this._streamer.Pause();
        else
          this._IAudioPlaybackManager.Pause();
      }
      catch (COMException ex)
      {
        throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
      }
    }

    public void Stop()
    {
      try
      {
        if (this.IsMSSTrackSet())
          this._streamer.Stop();
        else
          this._IAudioPlaybackManager.Stop();
      }
      catch (COMException ex)
      {
        throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
      }
    }

    public void FastForward()
    {
      if (this.IsMSSTrackSet())
        throw new InvalidOperationException();
      try
      {
        this._IAudioPlaybackManager.FastForward();
      }
      catch (COMException ex)
      {
        throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
      }
    }

    public void Rewind()
    {
      if (this.IsMSSTrackSet())
        throw new InvalidOperationException();
      try
      {
        this._IAudioPlaybackManager.Rewind();
      }
      catch (COMException ex)
      {
        throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
      }
    }

    public void SkipNext()
    {
      if (this._isHeadless)
        throw new InvalidOperationException();
      try
      {
        this._IAudioPlaybackManager.SkipNext();
      }
      catch (COMException ex)
      {
        throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
      }
    }

    public void SkipPrevious()
    {
      if (this._isHeadless)
        throw new InvalidOperationException();
      try
      {
        this._IAudioPlaybackManager.SkipPrevious();
      }
      catch (COMException ex)
      {
        throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
      }
    }

    public AudioTrack Track
    {
      get
      {
        AudioTrack.Initialize();
        IAudioTrack currentTrack;
        try
        {
          currentTrack = this._IAudioPlaybackManager.CurrentTrack;
        }
        catch (COMException ex)
        {
          throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
        }
        if (currentTrack == null)
          return (AudioTrack) null;
        return new AudioTrack(currentTrack);
      }
      set
      {
        if (value == null)
        {
          this.ClearQueue();
        }
        else
        {
          try
          {
            this._IAudioPlaybackManager.CurrentTrack = value.AudioTrackInterface;
          }
          catch (COMException ex)
          {
            throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
          }
        }
      }
    }

    public TimeSpan Position
    {
      get
      {
        try
        {
          return TimeSpan.FromMilliseconds((double) this._IAudioPlaybackManager.CurrentPosition);
        }
        catch (COMException ex)
        {
          throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
        }
      }
      set
      {
        try
        {
          if (this.IsMSSTrackSet())
            this._streamer.Position = value;
          else
            this._IAudioPlaybackManager.CurrentPosition = (int) value.TotalMilliseconds;
        }
        catch (COMException ex)
        {
          throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
        }
      }
    }

    public double BufferingProgress
    {
      get
      {
        try
        {
          return (double) (this._IAudioPlaybackManager.BufferingProgress / 100U);
        }
        catch (COMException ex)
        {
          throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
        }
      }
    }

    public bool CanPause
    {
      get
      {
        try
        {
          return this._IAudioPlaybackManager.CanPause;
        }
        catch (COMException ex)
        {
          return false;
        }
      }
    }

    public bool CanSeek
    {
      get
      {
        try
        {
          return this._IAudioPlaybackManager.CanSeek;
        }
        catch (COMException ex)
        {
          return false;
        }
      }
    }

    public double Volume
    {
      get
      {
        try
        {
          return this._IAudioPlaybackManager.Volume;
        }
        catch (COMException ex)
        {
          throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
        }
      }
      set
      {
        if (value >= 0.0)
        {
          if (value <= 1.0)
          {
            try
            {
              this._IAudioPlaybackManager.Volume = value;
              return;
            }
            catch (COMException ex)
            {
              throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
            }
          }
        }
        throw new ArgumentException();
      }
    }

    public Exception Error => this._CriticalErrorCode != 0 ? BackgroundAudioHelper.GetExceptionForHR(this._CriticalErrorCode, (COMException) null) : (Exception) null;

    public void Close()
    {
      try
      {
        this._IAudioPlaybackManager.Close();
      }
      catch (COMException ex)
      {
        throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
      }
    }

    private void ClearQueue()
    {
      try
      {
        if (this.IsMSSTrackSet())
          this._streamer.Close();
        this._IAudioPlaybackManager.Clear();
      }
      catch (COMException ex)
      {
        throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
      }
    }

    [SecuritySafeCritical]
    private void Initialize()
    {
      AudioTrack.Initialize();
      HostInfo hostInfo = new HostInfo();
      this._isHeadless = hostInfo.IsHeadlessHost;
      try
      {
        if (BackgroundAudioPlayer._appId == 0U)
          BackgroundAudioPlayer._appId = hostInfo.LastInstanceId;
        if (this._isHeadless)
          this._streamer = AudioStreamer.Instance;
        this._apmInterop = new AudioPlaybackManagerInterop();
        this._IAudioPlaybackManager = (IAudioPlaybackManager) this._apmInterop;
        this._IAudioPlaybackManager.Initialize(BackgroundAudioPlayer._appId);
        if (this._isHeadless || this._EventCallback != null)
          return;
        this._EventCallback = (IAudioPlaybackManagerCallback) new AudioPlaybackManagerCallback();
        this._IAudioPlaybackManager.EventCallback = this._EventCallback;
      }
      catch (COMException ex)
      {
        throw BackgroundAudioHelper.GetExceptionForHR(ex.ErrorCode, ex);
      }
    }

    internal void HandlePlayStateChanged(PlayState NewPlayState, bool fIsAPlayStateChangedEvent)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.HandlePlayStateChanged(NewPlayState, fIsAPlayStateChangedEvent)));
      }
      else
      {
        EventHandler playStateChanged = this.PlayStateChanged;
        if (playStateChanged == null)
          return;
        if (QuirksMode.ShouldAllowPlayStateChangedEventArgs())
        {
          PlayStateChangedEventArgs changedEventArgs = new PlayStateChangedEventArgs(NewPlayState);
          playStateChanged((object) this, (EventArgs) changedEventArgs);
        }
        else
        {
          if (!fIsAPlayStateChangedEvent)
            return;
          playStateChanged((object) this, EventArgs.Empty);
        }
      }
    }

    internal void HandleCriticalError(int hr)
    {
      if (this._CriticalErrorCode != 0)
        return;
      this._CriticalErrorCode = hr;
    }

    private bool IsMSSTrackSet()
    {
      AudioTrack track = this.Track;
      return track != null && (Uri) null == track.Source && this._streamer != null;
    }

    private BackgroundAudioPlayer()
    {
    }
  }
}
