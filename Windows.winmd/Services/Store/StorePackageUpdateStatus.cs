// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StorePackageUpdateStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ContractVersion(typeof (StoreContract), 65536)]
  public struct StorePackageUpdateStatus
  {
    public string PackageFamilyName;
    public ulong PackageDownloadSizeInBytes;
    public ulong PackageBytesDownloaded;
    public double PackageDownloadProgress;
    public double TotalDownloadProgress;
    public StorePackageUpdateState PackageUpdateState;
  }
}
