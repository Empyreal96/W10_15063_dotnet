// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneLineCellularDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [Guid(421921237, 5244, 18281, 182, 115, 152, 165, 236, 132, 38, 203)]
  [ExclusiveTo(typeof (PhoneLineCellularDetails))]
  internal interface IPhoneLineCellularDetails
  {
    PhoneSimState SimState { get; }

    int SimSlotIndex { get; }

    bool IsModemOn { get; }

    int RegistrationRejectCode { get; }

    string GetNetworkOperatorDisplayText(
      PhoneLineNetworkOperatorDisplayTextLocation location);
  }
}
