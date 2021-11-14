// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Background.PhoneCallBlockedReason
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls.Background
{
  [ContractVersion(typeof (CallsBackgroundContract), 65536)]
  [PreviousContractVersion("Windows.ApplicationModel.Calls.CallsPhoneContract", 65536, 131072)]
  public enum PhoneCallBlockedReason
  {
    InCallBlockingList,
    PrivateNumber,
    UnknownNumber,
  }
}
