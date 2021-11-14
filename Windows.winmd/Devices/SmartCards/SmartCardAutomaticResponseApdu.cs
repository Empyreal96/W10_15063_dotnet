// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardAutomaticResponseApdu
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ISmartCardAutomaticResponseApduFactory), 65536, "Windows.Devices.SmartCards.SmartCardEmulatorContract")]
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  public sealed class SmartCardAutomaticResponseApdu : 
    ISmartCardAutomaticResponseApdu,
    ISmartCardAutomaticResponseApdu2,
    ISmartCardAutomaticResponseApdu3
  {
    [MethodImpl]
    public extern SmartCardAutomaticResponseApdu(IBuffer commandApdu, IBuffer responseApdu);

    public extern IBuffer CommandApdu { [MethodImpl] get; [MethodImpl] set; }

    public extern IBuffer CommandApduBitMask { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ShouldMatchLength { [MethodImpl] get; [MethodImpl] set; }

    public extern IBuffer AppletId { [MethodImpl] get; [MethodImpl] set; }

    public extern IBuffer ResponseApdu { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<uint> InputState { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<uint> OutputState { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AllowWhenCryptogramGeneratorNotPrepared { [MethodImpl] get; [MethodImpl] set; }
  }
}
