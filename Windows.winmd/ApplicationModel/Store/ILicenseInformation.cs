// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.ILicenseInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store
{
  [ExclusiveTo(typeof (LicenseInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2394414128, 61808, 20181, 142, 33, 21, 22, 218, 63, 211, 103)]
  internal interface ILicenseInformation
  {
    IMapView<string, ProductLicense> ProductLicenses { get; }

    bool IsActive { get; }

    bool IsTrial { get; }

    DateTime ExpirationDate { get; }

    event LicenseChangedEventHandler LicenseChanged;
  }
}
