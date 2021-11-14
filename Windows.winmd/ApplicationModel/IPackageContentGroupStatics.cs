// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageContentGroupStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (PackageContentGroup))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1894675993, 24338, 19346, 185, 234, 108, 202, 218, 19, 188, 117)]
  internal interface IPackageContentGroupStatics
  {
    string RequiredGroupName { get; }
  }
}
