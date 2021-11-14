// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageCatalogAddOptionalPackageResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PackageCatalogAddOptionalPackageResult))]
  [Guid(1005653204, 46303, 18355, 169, 99, 226, 250, 131, 47, 125, 211)]
  internal interface IPackageCatalogAddOptionalPackageResult
  {
    Package Package { get; }

    HResult ExtendedError { get; }
  }
}
