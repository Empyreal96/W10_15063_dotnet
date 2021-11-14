// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManager4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [ExclusiveTo(typeof (PackageManager))]
  [Guid(1014077795, 47798, 18111, 143, 247, 218, 71, 25, 35, 10, 230)]
  internal interface IPackageManager4
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<PackageVolume>> GetPackageVolumesAsync();
  }
}
