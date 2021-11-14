// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageIdWithMetadata
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [Guid(1079474812, 3230, 17469, 144, 116, 133, 95, 92, 224, 160, 141)]
  [ExclusiveTo(typeof (PackageId))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPackageIdWithMetadata
  {
    string ProductId { get; }

    string Author { get; }
  }
}
