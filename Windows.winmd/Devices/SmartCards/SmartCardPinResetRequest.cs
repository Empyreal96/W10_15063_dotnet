// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardPinResetRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SmartCardPinResetRequest : ISmartCardPinResetRequest
  {
    public extern IBuffer Challenge { [MethodImpl] get; }

    public extern DateTime Deadline { [MethodImpl] get; }

    [MethodImpl]
    public extern SmartCardPinResetDeferral GetDeferral();

    [MethodImpl]
    public extern void SetResponse(IBuffer response);
  }
}
