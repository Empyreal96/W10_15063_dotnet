// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.LicenseManagement.ILicenseSatisfactionResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.LicenseManagement
{
  [ExclusiveTo(typeof (LicenseSatisfactionResult))]
  [Guid(1013403507, 15495, 20193, 130, 1, 244, 40, 53, 155, 211, 175)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ILicenseSatisfactionResult
  {
    IMapView<string, LicenseSatisfactionInfo> LicenseSatisfactionInfos { get; }

    HResult ExtendedError { get; }
  }
}
