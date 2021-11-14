// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandUiccAppReadRecordResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  [Guid(1690915461, 13710, 18373, 130, 73, 105, 95, 56, 59, 43, 219)]
  [ExclusiveTo(typeof (MobileBroadbandUiccAppReadRecordResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMobileBroadbandUiccAppReadRecordResult
  {
    MobileBroadbandUiccAppOperationStatus Status { get; }

    IBuffer Data { get; }
  }
}
