// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.TaskModel.Interop.HostInfo
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.IO;
using System.Security;
using System.Text;

namespace Microsoft.Phone.TaskModel.Interop
{
  [SecuritySafeCritical]
  internal class HostInfo
  {
    internal const string AppDataUriScheme = "appdata";
    internal const string IsoStoreUriScheme = "isostore";
    internal const string fileUriScheme = "file";
    internal uint MaxPath = 260;
    private HostInformation _hostInformation;

    public HostInfo()
    {
      this._hostInformation.ullLastInstanceId = 0U;
      this._hostInformation.hHostWnd = IntPtr.Zero;
      this._hostInformation.hTouchWnd = IntPtr.Zero;
      HostInfoNativeMethods.GetHostInfo(out this._hostInformation);
    }

    ~HostInfo()
    {
    }

    public uint LastInstanceId => this._hostInformation.ullLastInstanceId;

    public string ProductId => this._hostInformation.szProductId;

    public IntPtr HostWnd
    {
      get
      {
        IntPtr zero = IntPtr.Zero;
        return this._hostInformation.hHostWnd;
      }
    }

    public IntPtr TouchWnd
    {
      get
      {
        IntPtr zero = IntPtr.Zero;
        return this._hostInformation.hTouchWnd;
      }
    }

    public string AppInstallFolder => this._hostInformation.szAppInstallFolder;

    public string AppDataFolder => this._hostInformation.szAppDataFolder;

    public string AppIsolatedStorePath => this._hostInformation.szAppIsolatedStorePath;

    public string Uri => this._hostInformation.szUri;

    public string TaskPage => this._hostInformation.szTaskPage;

    public bool Rehydrated => this._hostInformation.fRehydrated > 0U;

    public bool Dehydrating => this._hostInformation.fDehydrating > 0U;

    public bool IsHeadlessHost => this._hostInformation.fIsHeadlessHost > 0U;

    public string GuidInstanceId => this._hostInformation.szGuidInstanceId;

    [SecuritySafeCritical]
    public string GetFileSystemPath(string uri)
    {
      System.Uri uri1 = !string.IsNullOrEmpty(uri) ? new System.Uri(uri, UriKind.RelativeOrAbsolute) : throw new ArgumentException(nameof (uri));
      if (uri1.IsAbsoluteUri && (uri1.Port != -1 || !string.IsNullOrEmpty(uri1.Query) || !string.IsNullOrEmpty(uri1.Host)))
        throw new ArgumentException(nameof (uri));
      string path1;
      if (!uri1.IsAbsoluteUri || string.CompareOrdinal(uri1.Scheme, "appdata") == 0 || string.CompareOrdinal(uri1.Scheme, "file") == 0)
      {
        path1 = this.AppInstallFolder;
      }
      else
      {
        if (string.CompareOrdinal(uri1.Scheme, "isostore") != 0)
          throw new ArgumentException(nameof (uri));
        path1 = this.AppIsolatedStorePath;
      }
      string path2 = !uri1.IsAbsoluteUri ? uri1.OriginalString : uri1.LocalPath;
      if (path2 == null)
        throw new ArgumentException(nameof (uri));
      if (path2.StartsWith("/") || path2.StartsWith("\\"))
        path2 = path2.Substring(1);
      string pathName = Path.Combine(path1, path2);
      StringBuilder canonicalPathName = new StringBuilder((int) this.MaxPath);
      if (HostInfoNativeMethods.GetCanonicalPathName(pathName, canonicalPathName, this.MaxPath) == 0U)
        throw new ArgumentException(nameof (uri));
      string str = canonicalPathName.ToString();
      return str.StartsWith(path1, StringComparison.InvariantCultureIgnoreCase) ? str : throw new ArgumentException(nameof (uri));
    }

    public uint AppTargetRuntimeMajorVersion => this._hostInformation.uAppTargetMajorVersion;

    public uint AppTargetRuntimeMinorVersion => this._hostInformation.uAppTargetMinorVersion;

    public ApplicationType ApplicationType => this._hostInformation.appType;
  }
}
