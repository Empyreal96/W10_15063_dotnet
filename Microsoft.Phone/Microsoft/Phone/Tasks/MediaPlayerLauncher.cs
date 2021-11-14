// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.MediaPlayerLauncher
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using Windows.Foundation;
using Windows.System;

namespace Microsoft.Phone.Tasks
{
  public class MediaPlayerLauncher
  {
    private MediaPlaybackControls _controls;
    private Uri _media;
    private MediaLocationType _locationHint;
    private MediaPlayerOrientation _orientation;

    public MediaPlayerLauncher()
    {
      this.Controls = MediaPlaybackControls.All;
      this._locationHint = MediaLocationType.Data;
    }

    public Uri Media
    {
      get => this._media;
      set => this._media = this.ValidateUri(value) ? value : throw new ArgumentException(nameof (value));
    }

    public MediaPlaybackControls Controls
    {
      get => this._controls;
      set => this._controls = (value & ~MediaPlaybackControls.All) == MediaPlaybackControls.None ? value : throw new ArgumentException();
    }

    public MediaLocationType Location
    {
      get => this._locationHint;
      set => this._locationHint = value;
    }

    public MediaPlayerOrientation Orientation
    {
      get => this._orientation;
      set
      {
        switch (value)
        {
          case MediaPlayerOrientation.Landscape:
          case MediaPlayerOrientation.Portrait:
            this._orientation = value;
            break;
          default:
            throw new ArgumentException();
        }
      }
    }

    public void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      if (this.Media == (Uri) null)
        throw new InvalidOperationException();
      string relative = "playurl/?" + string.Join("&", (IEnumerable<string>) new List<string>()
      {
        "url=" + this.AdjustUri(this.Media),
        "controls=" + (object) (int) this.Controls,
        "orientation=" + (object) (int) this.Orientation
      });
      if (ApplicationHost.Current.IsHeadless)
        throw new InvalidOperationException("Cannot launch a session in headless host");
      WindowsRuntimeSystemExtensions.AsTask<bool>((IAsyncOperation<M0>) Launcher.LaunchUriAsync(MeuxHelper.MakeLitePlayerUri(relative)));
      ChooserHelper.FlagExternalNavigationPendingIfNotInProgress();
    }

    private string AdjustUri(Uri inputUri)
    {
      if (inputUri.IsAbsoluteUri)
        return Uri.EscapeDataString(inputUri.AbsoluteUri);
      string absolutePath = this.ResolveToAbsolutePath(inputUri);
      Console.WriteLine("MediaPlayerLauncher: passing path to meux = " + absolutePath);
      return Uri.EscapeDataString(absolutePath);
    }

    private bool ValidateUri(Uri uri)
    {
      if (!uri.IsAbsoluteUri)
        return true;
      string scheme = uri.Scheme;
      return string.Compare(scheme, "https", StringComparison.InvariantCultureIgnoreCase) == 0 || string.Compare(scheme, "http", StringComparison.InvariantCultureIgnoreCase) == 0;
    }

    private string GetFullyQualifiedPath(Uri relativeUri, string folder)
    {
      string path2 = relativeUri.OriginalString.Replace('/', '\\');
      string str = Path.Combine(folder, path2);
      Console.WriteLine("GetFullyQualifiedPath fullFilePath = " + str);
      return str;
    }

    [SecuritySafeCritical]
    private string ResolveToAbsolutePath(Uri relativeUri)
    {
      HostInfo hostInfo = new HostInfo();
      Console.WriteLine("ResolveToAbsolutePath AppDataFolder = " + hostInfo.AppDataFolder);
      Console.WriteLine("ResolveToAbsolutePath AppInstallFolder = " + hostInfo.AppInstallFolder);
      Console.WriteLine("ResolveToAbsolutePath AppIsolatedStorePath = " + hostInfo.AppIsolatedStorePath);
      string fullyQualifiedPath;
      if (this._locationHint == MediaLocationType.Install)
      {
        fullyQualifiedPath = this.GetFullyQualifiedPath(relativeUri, hostInfo.AppInstallFolder);
      }
      else
      {
        if (this._locationHint != MediaLocationType.Data)
          throw new FileNotFoundException(relativeUri.OriginalString);
        fullyQualifiedPath = this.GetFullyQualifiedPath(relativeUri, hostInfo.AppIsolatedStorePath);
      }
      if (!File.Exists(fullyQualifiedPath))
      {
        Console.WriteLine("MediaPlayerLauncher: ResolveToAbsolutePath failed path validation = " + fullyQualifiedPath);
        throw new FileNotFoundException(fullyQualifiedPath);
      }
      return fullyQualifiedPath;
    }
  }
}
