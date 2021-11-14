// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManagerDebugSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ExclusiveTo(typeof (PackageManagerDebugSettings))]
  [Guid(442570371, 43400, 20431, 143, 15, 206, 23, 88, 152, 232, 235)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPackageManagerDebugSettings
  {
    [Overload("SetContentGroupStateAsync")]
    [RemoteAsync]
    IAsyncAction SetContentGroupStateAsync(
      Package package,
      string contentGroupName,
      PackageContentGroupState state);

    [RemoteAsync]
    [Overload("SetContentGroupStateWithPercentageAsync")]
    IAsyncAction SetContentGroupStateAsync(
      Package package,
      string contentGroupName,
      PackageContentGroupState state,
      double completionPercentage);
  }
}
