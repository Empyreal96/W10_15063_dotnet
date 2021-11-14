// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.UnifiedPosErrorData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UnifiedPosErrorData : IUnifiedPosErrorData
  {
    public extern string Message { [MethodImpl] get; }

    public extern UnifiedPosErrorSeverity Severity { [MethodImpl] get; }

    public extern UnifiedPosErrorReason Reason { [MethodImpl] get; }

    public extern uint ExtendedReason { [MethodImpl] get; }
  }
}
