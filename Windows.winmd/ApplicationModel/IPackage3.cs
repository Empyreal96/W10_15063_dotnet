// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackage3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Package))]
  [Guid(1601407841, 63594, 18711, 147, 209, 241, 238, 157, 59, 53, 217)]
  internal interface IPackage3
  {
    PackageStatus Status { get; }

    DateTime InstalledDate { get; }

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppListEntry>> GetAppListEntriesAsync();
  }
}
