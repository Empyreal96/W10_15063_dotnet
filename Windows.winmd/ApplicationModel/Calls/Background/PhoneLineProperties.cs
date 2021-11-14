// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.Background.PhoneLineProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls.Background
{
  [ContractVersion(typeof (CallsBackgroundContract), 65536)]
  [Flags]
  [PreviousContractVersion("Windows.ApplicationModel.Calls.CallsPhoneContract", 65536, 131072)]
  public enum PhoneLineProperties : uint
  {
    None = 0,
    BrandingOptions = 1,
    CanDial = 2,
    CellularDetails = 4,
    DisplayColor = 8,
    DisplayName = 16, // 0x00000010
    NetworkName = 32, // 0x00000020
    NetworkState = 64, // 0x00000040
    Transport = 128, // 0x00000080
    Voicemail = 256, // 0x00000100
  }
}
