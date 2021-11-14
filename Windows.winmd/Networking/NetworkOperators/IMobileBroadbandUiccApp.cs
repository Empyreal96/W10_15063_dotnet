// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandUiccApp
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MobileBroadbandUiccApp))]
  [Guid(1293354326, 39073, 17373, 178, 236, 80, 201, 12, 242, 72, 223)]
  internal interface IMobileBroadbandUiccApp
  {
    IBuffer Id { get; }

    UiccAppKind Kind { get; }

    IAsyncOperation<MobileBroadbandUiccAppRecordDetailsResult> GetRecordDetailsAsync(
      IIterable<uint> uiccFilePath);

    IAsyncOperation<MobileBroadbandUiccAppReadRecordResult> ReadRecordAsync(
      IIterable<uint> uiccFilePath,
      int recordIndex);
  }
}
