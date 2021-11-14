// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundAudio.AudioTrack
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.BackgroundAudio.Interop;
using Microsoft.Phone.TaskModel.Interop;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace Microsoft.Phone.BackgroundAudio
{
  public class AudioTrack : IEditableObject
  {
    private uint _id;
    private Uri _source;
    private string _title;
    private string _artist;
    private string _album;
    private Uri _albumArt;
    private string _tag;
    private EnabledPlayerControls _enabledControls = EnabledPlayerControls.All;
    private IAudioTrack _IAudioTrack;
    private static object _staticsLock = new object();
    private static string _isolatedStoreRoot = (string) null;
    private static Uri _isolatedStoreUri = (Uri) null;
    private bool _isInEditMode;

    internal AudioTrack(uint id)
    {
      AudioTrack.Initialize();
      this._id = id;
      this._IAudioTrack = (IAudioTrack) new AudioTrackInterop();
      this.CopyFromIAudioTrack(true);
    }

    internal AudioTrack(IAudioTrack track)
    {
      AudioTrack.Initialize();
      this._IAudioTrack = track;
      this.CopyFromIAudioTrack(false);
    }

    public AudioTrack()
    {
      AudioTrack.Initialize();
      this._IAudioTrack = (IAudioTrack) new AudioTrackInterop();
    }

    public AudioTrack(Uri source, string title, string artist, string album, Uri albumArt)
    {
      AudioTrack.Initialize();
      this._source = AudioTrack.ValidateUri(source);
      this._title = title;
      this._artist = artist;
      this._album = album;
      this._albumArt = AudioTrack.ValidateUri(albumArt);
      this._IAudioTrack = (IAudioTrack) new AudioTrackInterop();
      this.CopyIntoIAudioTrack();
    }

    public AudioTrack(
      Uri source,
      string title,
      string artist,
      string album,
      Uri albumArt,
      string tag,
      EnabledPlayerControls enabledControls)
    {
      AudioTrack.Initialize();
      this._source = AudioTrack.ValidateUri(source);
      this._title = title;
      this._artist = artist;
      this._album = album;
      this._albumArt = AudioTrack.ValidateUri(albumArt);
      this._tag = tag;
      this._enabledControls = enabledControls;
      this._IAudioTrack = (IAudioTrack) new AudioTrackInterop();
      this.CopyIntoIAudioTrack();
    }

    public Uri Source
    {
      get => this.SanitizeUri(this._source);
      set
      {
        if (!this._isInEditMode)
          throw new InvalidOperationException();
        this._source = AudioTrack.ValidateUri(value);
      }
    }

    public string Title
    {
      get => this._title;
      set
      {
        if (!this._isInEditMode)
          throw new InvalidOperationException();
        this._title = value;
      }
    }

    public string Artist
    {
      get => this._artist;
      set
      {
        if (!this._isInEditMode)
          throw new InvalidOperationException();
        this._artist = value;
      }
    }

    public string Album
    {
      get => this._album;
      set
      {
        if (!this._isInEditMode)
          throw new InvalidOperationException();
        this._album = value;
      }
    }

    public string Tag
    {
      get => this._tag;
      set
      {
        if (!this._isInEditMode)
          throw new InvalidOperationException();
        this._tag = value;
      }
    }

    public Uri AlbumArt
    {
      get => this.SanitizeUri(this._albumArt);
      set
      {
        if (!this._isInEditMode)
          throw new InvalidOperationException();
        this._albumArt = AudioTrack.ValidateUri(value);
      }
    }

    public EnabledPlayerControls PlayerControls
    {
      get => this._enabledControls;
      set
      {
        if (!this._isInEditMode)
          throw new InvalidOperationException();
        this._enabledControls = value;
      }
    }

    public TimeSpan Duration => TimeSpan.FromMilliseconds((double) this._IAudioTrack.Duration);

    internal IAudioTrack AudioTrackInterface => this._IAudioTrack;

    private static string IsolatedStoreRoot
    {
      get
      {
        if (Interlocked.CompareExchange<string>(ref AudioTrack._isolatedStoreRoot, (string) null, (string) null) == null)
        {
          lock (AudioTrack._staticsLock)
          {
            if (AudioTrack._isolatedStoreRoot == null)
            {
              HostInfo hostInfo = new HostInfo();
              Interlocked.Exchange<string>(ref AudioTrack._isolatedStoreRoot, hostInfo.AppIsolatedStorePath);
            }
          }
        }
        return AudioTrack._isolatedStoreRoot;
      }
    }

    private static Uri IsolatedStoreUri
    {
      get
      {
        if ((Uri) null == AudioTrack._isolatedStoreUri)
          AudioTrack._isolatedStoreUri = !AudioTrack.IsolatedStoreRoot.EndsWith("/") ? new Uri(AudioTrack.IsolatedStoreRoot + "/", UriKind.Absolute) : new Uri(AudioTrack.IsolatedStoreRoot, UriKind.Absolute);
        return AudioTrack._isolatedStoreUri;
      }
    }

    private static Uri ValidateUri(string stringSource) => stringSource == null ? (Uri) null : AudioTrack.ValidateUri(new Uri(stringSource, UriKind.RelativeOrAbsolute));

    private static Uri ValidateUri(Uri uriSource)
    {
      if ((Uri) null == uriSource)
        return (Uri) null;
      return uriSource.IsAbsoluteUri ? uriSource : new Uri(Path.Combine(AudioTrack.IsolatedStoreRoot, Uri.UnescapeDataString(uriSource.ToString())), UriKind.Absolute);
    }

    private Uri SanitizeUri(Uri original) => (Uri) null != original && AudioTrack.IsolatedStoreUri.IsBaseOf(original) ? AudioTrack.IsolatedStoreUri.MakeRelativeUri(original) : original;

    private static string ValidateString(string stringSource) => stringSource == null ? (string) null : stringSource;

    private void CopyFromIAudioTrack(bool ShouldInitialize)
    {
      if (ShouldInitialize)
        this._IAudioTrack.Initialize(this._id);
      else
        this._id = this._IAudioTrack.TrackId;
      this._source = AudioTrack.ValidateUri(this._IAudioTrack.Uri);
      this._title = AudioTrack.ValidateString(this._IAudioTrack.Title);
      this._artist = AudioTrack.ValidateString(this._IAudioTrack.Artist);
      this._album = AudioTrack.ValidateString(this._IAudioTrack.Album);
      this._albumArt = AudioTrack.ValidateUri(this._IAudioTrack.AlbumArtUri);
      this._tag = AudioTrack.ValidateString(this._IAudioTrack.Tag);
      this._enabledControls = (EnabledPlayerControls) this._IAudioTrack.PlayerControls;
    }

    private void CopyIntoIAudioTrack()
    {
      if ((Uri) null != this._source)
        this._IAudioTrack.Uri = this._source.ToString();
      this._IAudioTrack.Title = this._title;
      this._IAudioTrack.Artist = this._artist;
      this._IAudioTrack.Album = this._album;
      if ((Uri) null != this._albumArt)
        this._IAudioTrack.AlbumArtUri = this._albumArt.ToString();
      this._IAudioTrack.Tag = this._tag;
      this._IAudioTrack.PlayerControls = (uint) this._enabledControls;
    }

    internal void Commit()
    {
      if (this._IAudioTrack == null)
        throw new InvalidOperationException();
      this.CopyIntoIAudioTrack();
      try
      {
        this._IAudioTrack.Commit();
      }
      catch (COMException ex)
      {
      }
    }

    [SecuritySafeCritical]
    internal static void Initialize()
    {
    }

    public void BeginEdit() => this._isInEditMode = true;

    public void CancelEdit() => throw new NotSupportedException();

    public void EndEdit()
    {
      if (!this._isInEditMode)
        return;
      this.Commit();
      this._isInEditMode = false;
    }
  }
}
