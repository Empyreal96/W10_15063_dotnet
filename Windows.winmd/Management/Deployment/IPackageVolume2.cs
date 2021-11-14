// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageVolume2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [Guid(1185664814, 40404, 18338, 171, 140, 198, 64, 131, 73, 188, 216)]
  [ExclusiveTo(typeof (PackageVolume))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPackageVolume2
  {
    bool IsFullTrustPackageSupported { get; }

    bool IsAppxInstallSupported { get; }

    [RemoteAsync]
    IAsyncOperation<ulong> GetAvailableSpaceAsync();
  }
}
