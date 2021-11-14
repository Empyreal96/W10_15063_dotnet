// Decompiled with JetBrains decompiler
// Type: Windows.Phone.UI.Core.CoreInputScope
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.UI.Core
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [WebHostHidden]
  public enum CoreInputScope
  {
    Default = 0,
    Url = 1,
    EmailSmtpAddress = 5,
    Number = 29, // 0x0000001D
    TelephoneNumber = 32, // 0x00000020
    Text = 49, // 0x00000031
    Search = 51, // 0x00000033
  }
}
