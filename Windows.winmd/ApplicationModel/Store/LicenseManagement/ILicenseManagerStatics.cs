// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.LicenseManagement.ILicenseManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Store.LicenseManagement
{
  [Guid(3047963360, 55879, 20256, 154, 35, 9, 24, 44, 148, 118, 255)]
  [ExclusiveTo(typeof (LicenseManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ILicenseManagerStatics
  {
    [RemoteAsync]
    IAsyncAction AddLicenseAsync(IBuffer license);

    [RemoteAsync]
    IAsyncOperation<LicenseSatisfactionResult> GetSatisfactionInfosAsync(
      IIterable<string> contentIds,
      IIterable<string> keyIds);
  }
}
