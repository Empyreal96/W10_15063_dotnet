// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandUiccApp
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MobileBroadbandUiccApp : IMobileBroadbandUiccApp
  {
    public extern IBuffer Id { [MethodImpl] get; }

    public extern UiccAppKind Kind { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandUiccAppRecordDetailsResult> GetRecordDetailsAsync(
      IIterable<uint> uiccFilePath);

    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandUiccAppReadRecordResult> ReadRecordAsync(
      IIterable<uint> uiccFilePath,
      int recordIndex);
  }
}
