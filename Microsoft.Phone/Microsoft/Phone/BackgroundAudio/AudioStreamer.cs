// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundAudio.AudioStreamer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace Microsoft.Phone.BackgroundAudio
{
  public sealed class AudioStreamer
  {
    private static volatile AudioStreamer _instance;
    private static object syncRoot = new object();
    private MediaElement _mediaElement;
    private DispatcherSynchronizationContext _syncContext;

    internal static AudioStreamer Instance
    {
      get
      {
        if (AudioStreamer._instance == null)
        {
          lock (AudioStreamer.syncRoot)
          {
            if (AudioStreamer._instance == null)
              AudioStreamer._instance = new AudioStreamer();
          }
        }
        return AudioStreamer._instance;
      }
    }

    public void SetSource(MediaStreamSource source)
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        this._syncContext.Send((SendOrPostCallback) delegate
        {
          this.SetSource(source);
        }, (object) null);
      }
      else
      {
        lock (this)
        {
          UIElementCollection children = ((Panel) Application.Current.RootVisual).Children;
          if (this._mediaElement != null)
          {
            children.Remove((UIElement) this._mediaElement);
            this._mediaElement = (MediaElement) null;
          }
          this._mediaElement = new MediaElement();
          children.Add((UIElement) this._mediaElement);
          this._mediaElement.AutoPlay = false;
          this._mediaElement.SetSource(source);
        }
      }
    }

    internal void Play()
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        this._syncContext.Send((SendOrPostCallback) delegate
        {
          this.Play();
        }, (object) null);
      }
      else
      {
        lock (this)
        {
          if (this._mediaElement == null)
            return;
          this._mediaElement.Play();
        }
      }
    }

    internal void Pause()
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        this._syncContext.Send((SendOrPostCallback) delegate
        {
          this.Pause();
        }, (object) null);
      }
      else
      {
        lock (this)
        {
          if (this._mediaElement == null)
            return;
          this._mediaElement.Pause();
        }
      }
    }

    internal void Stop()
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        this._syncContext.Send((SendOrPostCallback) delegate
        {
          this.Stop();
        }, (object) null);
      }
      else
      {
        lock (this)
        {
          if (this._mediaElement == null)
            return;
          this._mediaElement.Stop();
        }
      }
    }

    internal TimeSpan Position
    {
      set
      {
        if (!Deployment.Current.Dispatcher.CheckAccess())
        {
          this._syncContext.Send((SendOrPostCallback) delegate
          {
            this.Position = value;
          }, (object) null);
        }
        else
        {
          lock (this)
          {
            if (this._mediaElement == null)
              return;
            this._mediaElement.Position = value;
          }
        }
      }
    }

    internal void Close()
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        this._syncContext.Send((SendOrPostCallback) delegate
        {
          this.Close();
        }, (object) null);
      }
      else
      {
        lock (this)
        {
          if (this._mediaElement == null)
            return;
          this._mediaElement.Stop();
          ((Panel) Application.Current.RootVisual).Children.Remove((UIElement) this._mediaElement);
          this._mediaElement = (MediaElement) null;
        }
      }
    }

    private AudioStreamer() => this._syncContext = new DispatcherSynchronizationContext(Deployment.Current.Dispatcher);
  }
}
