// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (Package))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1314081759, 10592, 18552, 151, 164, 150, 36, 222, 183, 47, 45)]
  internal interface IPackageStatics
  {
    Package Current { get; }
  }
}
