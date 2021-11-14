// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageStatus2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4096326291, 31830, 18530, 172, 250, 171, 174, 220, 192, 105, 77)]
  [ExclusiveTo(typeof (PackageStatus))]
  internal interface IPackageStatus2
  {
    bool IsPartiallyStaged { get; }
  }
}
