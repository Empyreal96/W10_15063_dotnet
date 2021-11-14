// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsEncoding
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SmsEncoding
  {
    Unknown,
    Optimal,
    SevenBitAscii,
    Unicode,
    GsmSevenBit,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] EightBit,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Latin,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Korean,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] IA5,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ShiftJis,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] LatinHebrew,
  }
}
