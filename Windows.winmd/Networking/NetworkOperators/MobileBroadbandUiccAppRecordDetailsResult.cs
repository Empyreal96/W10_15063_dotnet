// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandUiccAppRecordDetailsResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MobileBroadbandUiccAppRecordDetailsResult : 
    IMobileBroadbandUiccAppRecordDetailsResult
  {
    public extern MobileBroadbandUiccAppOperationStatus Status { [MethodImpl] get; }

    public extern UiccAppRecordKind Kind { [MethodImpl] get; }

    public extern int RecordCount { [MethodImpl] get; }

    public extern int RecordSize { [MethodImpl] get; }

    public extern UiccAccessCondition ReadAccessCondition { [MethodImpl] get; }

    public extern UiccAccessCondition WriteAccessCondition { [MethodImpl] get; }
  }
}
