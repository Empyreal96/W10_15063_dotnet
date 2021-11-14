// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Media.MediaStreamer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Microsoft.Phone.Media
{
  public sealed class MediaStreamer : IDisposable
  {
    private MediaElement _mediaElement;
    private MediaStreamSource _mss;
    private int _intId;
    private bool _disposed;

    internal MediaStreamer(int id) => this._intId = id;

    public void SetSource(MediaStreamSource remoteStream)
    {
      if (this._disposed)
        throw new ObjectDisposedException("MediaStreamer " + this._intId.ToString());
      if (remoteStream == null)
        throw new ArgumentNullException(nameof (remoteStream));
      if (!Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => this.SetSource(remoteStream)));
      }
      else
      {
        this._mss = remoteStream;
        this._mss.MediaStreamerId = this._intId;
        if (this._mediaElement != null)
        {
          this._mediaElement.MediaOpened -= new RoutedEventHandler(this.OnMediaElementOpened);
          this._mediaElement.MediaEnded -= new RoutedEventHandler(this.OnMediaElementEnded);
          this._mediaElement.MediaFailed -= new EventHandler<ExceptionRoutedEventArgs>(this.OnMediaElementFailed);
        }
        this._mediaElement = new MediaElement();
        this._mediaElement.MediaOpened += new RoutedEventHandler(this.OnMediaElementOpened);
        this._mediaElement.MediaEnded += new RoutedEventHandler(this.OnMediaElementEnded);
        this._mediaElement.MediaFailed += new EventHandler<ExceptionRoutedEventArgs>(this.OnMediaElementFailed);
        this._mediaElement.SetSource(this._mss);
      }
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    ~MediaStreamer() => this.Dispose(false);

    private void Dispose(bool disposing)
    {
      if (this._disposed)
        return;
      this._mediaElement.Source = (Uri) null;
      MediaStreamerFactory.MakeInactive(this);
      this._disposed = true;
    }

    internal void OnMediaElementFailed(object sender, ExceptionRoutedEventArgs args)
    {
      EventHandler<MediaStreamerFailedEventArgs> mediaFailed = this.MediaFailed;
      if (mediaFailed == null)
        return;
      mediaFailed(sender, new MediaStreamerFailedEventArgs()
      {
        ErrorException = args.ErrorException
      });
    }

    internal void OnMediaElementEnded(object sender, RoutedEventArgs args)
    {
      EventHandler<MediaStreamerEndedEventArgs> mediaEnded = this.MediaEnded;
      if (mediaEnded == null)
        return;
      mediaEnded(sender, new MediaStreamerEndedEventArgs());
    }

    internal void OnMediaElementOpened(object sender, RoutedEventArgs args)
    {
      EventHandler<MediaStreamerOpenedEventArgs> mediaOpened = this.MediaOpened;
      if (mediaOpened == null)
        return;
      mediaOpened(sender, new MediaStreamerOpenedEventArgs());
    }

    public event EventHandler<MediaStreamerFailedEventArgs> MediaFailed;

    public event EventHandler<MediaStreamerEndedEventArgs> MediaEnded;

    public event EventHandler<MediaStreamerOpenedEventArgs> MediaOpened;
  }
}
