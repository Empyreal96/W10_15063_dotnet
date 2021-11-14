// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageManagerDebugSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PackageManagerDebugSettings : IPackageManagerDebugSettings
  {
    [Overload("SetContentGroupStateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetContentGroupStateAsync(
      Package package,
      string contentGroupName,
      PackageContentGroupState state);

    [Overload("SetContentGroupStateWithPercentageAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetContentGroupStateAsync(
      Package package,
      string contentGroupName,
      PackageContentGroupState state,
      double completionPercentage);
  }
}
