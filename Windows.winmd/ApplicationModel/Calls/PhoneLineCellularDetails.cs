// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneLineCellularDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PhoneLineCellularDetails : IPhoneLineCellularDetails
  {
    public extern PhoneSimState SimState { [MethodImpl] get; }

    public extern int SimSlotIndex { [MethodImpl] get; }

    public extern bool IsModemOn { [MethodImpl] get; }

    public extern int RegistrationRejectCode { [MethodImpl] get; }

    [MethodImpl]
    public extern string GetNetworkOperatorDisplayText(
      PhoneLineNetworkOperatorDisplayTextLocation location);
  }
}
