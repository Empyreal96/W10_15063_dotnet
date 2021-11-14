// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.InputScopeNameValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum InputScopeNameValue
  {
    Default = 0,
    Url = 1,
    EmailSmtpAddress = 5,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PersonalFullName = 7,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] CurrencyAmountAndSymbol = 20, // 0x00000014
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] CurrencyAmount = 21, // 0x00000015
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] DateMonthNumber = 23, // 0x00000017
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] DateDayNumber = 24, // 0x00000018
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] DateYear = 25, // 0x00000019
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Digits = 28, // 0x0000001C
    Number = 29, // 0x0000001D
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Password = 31, // 0x0000001F
    TelephoneNumber = 32, // 0x00000020
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TelephoneCountryCode = 33, // 0x00000021
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TelephoneAreaCode = 34, // 0x00000022
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TelephoneLocalNumber = 35, // 0x00000023
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TimeHour = 37, // 0x00000025
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TimeMinutesOrSeconds = 38, // 0x00000026
    NumberFullWidth = 39, // 0x00000027
    AlphanumericHalfWidth = 40, // 0x00000028
    AlphanumericFullWidth = 41, // 0x00000029
    Hiragana = 44, // 0x0000002C
    KatakanaHalfWidth = 45, // 0x0000002D
    KatakanaFullWidth = 46, // 0x0000002E
    Hanja = 47, // 0x0000002F
    HangulHalfWidth = 48, // 0x00000030
    HangulFullWidth = 49, // 0x00000031
    Search = 50, // 0x00000032
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Formula = 51, // 0x00000033
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] SearchIncremental = 52, // 0x00000034
    ChineseHalfWidth = 53, // 0x00000035
    ChineseFullWidth = 54, // 0x00000036
    NativeScript = 55, // 0x00000037
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Text = 57, // 0x00000039
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Chat = 58, // 0x0000003A
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NameOrPhoneNumber = 59, // 0x0000003B
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] EmailNameOrAddress = 60, // 0x0000003C
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Maps = 62, // 0x0000003E
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NumericPassword = 63, // 0x0000003F
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NumericPin = 64, // 0x00000040
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] AlphanumericPin = 65, // 0x00000041
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] FormulaNumber = 67, // 0x00000043
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] ChatWithoutEmoji = 68, // 0x00000044
  }
}
