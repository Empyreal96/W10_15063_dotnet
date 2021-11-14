// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (Package))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(373061935, 48501, 16700, 191, 35, 177, 254, 123, 149, 216, 37)]
  internal interface IPackage
  {
    PackageId Id { get; }

    StorageFolder InstalledLocation { get; }

    bool IsFramework { get; }

    IVectorView<Package> Dependencies { get; }
  }
}
