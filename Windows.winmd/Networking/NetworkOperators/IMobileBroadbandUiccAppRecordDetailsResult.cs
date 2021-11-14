// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandUiccAppRecordDetailsResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandUiccAppRecordDetailsResult))]
  [Guid(3642320943, 48660, 18740, 152, 29, 47, 87, 185, 237, 131, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMobileBroadbandUiccAppRecordDetailsResult
  {
    MobileBroadbandUiccAppOperationStatus Status { get; }

    UiccAppRecordKind Kind { get; }

    int RecordCount { get; }

    int RecordSize { get; }

    UiccAccessCondition ReadAccessCondition { get; }

    UiccAccessCondition WriteAccessCondition { get; }
  }
}
