// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextInputScope
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CoreTextInputScope
  {
    Default = 0,
    Url = 1,
    FilePath = 2,
    FileName = 3,
    EmailUserName = 4,
    EmailAddress = 5,
    UserName = 6,
    PersonalFullName = 7,
    PersonalNamePrefix = 8,
    PersonalGivenName = 9,
    PersonalMiddleName = 10, // 0x0000000A
    PersonalSurname = 11, // 0x0000000B
    PersonalNameSuffix = 12, // 0x0000000C
    Address = 13, // 0x0000000D
    AddressPostalCode = 14, // 0x0000000E
    AddressStreet = 15, // 0x0000000F
    AddressStateOrProvince = 16, // 0x00000010
    AddressCity = 17, // 0x00000011
    AddressCountryName = 18, // 0x00000012
    AddressCountryShortName = 19, // 0x00000013
    CurrencyAmountAndSymbol = 20, // 0x00000014
    CurrencyAmount = 21, // 0x00000015
    Date = 22, // 0x00000016
    DateMonth = 23, // 0x00000017
    DateDay = 24, // 0x00000018
    DateYear = 25, // 0x00000019
    DateMonthName = 26, // 0x0000001A
    DateDayName = 27, // 0x0000001B
    Number = 29, // 0x0000001D
    SingleCharacter = 30, // 0x0000001E
    Password = 31, // 0x0000001F
    TelephoneNumber = 32, // 0x00000020
    TelephoneCountryCode = 33, // 0x00000021
    TelephoneAreaCode = 34, // 0x00000022
    TelephoneLocalNumber = 35, // 0x00000023
    Time = 36, // 0x00000024
    TimeHour = 37, // 0x00000025
    TimeMinuteOrSecond = 38, // 0x00000026
    NumberFullWidth = 39, // 0x00000027
    AlphanumericHalfWidth = 40, // 0x00000028
    AlphanumericFullWidth = 41, // 0x00000029
    CurrencyChinese = 42, // 0x0000002A
    Bopomofo = 43, // 0x0000002B
    Hiragana = 44, // 0x0000002C
    KatakanaHalfWidth = 45, // 0x0000002D
    KatakanaFullWidth = 46, // 0x0000002E
    Hanja = 47, // 0x0000002F
    HangulHalfWidth = 48, // 0x00000030
    HangulFullWidth = 49, // 0x00000031
    Search = 50, // 0x00000032
    Formula = 51, // 0x00000033
    SearchIncremental = 52, // 0x00000034
    ChineseHalfWidth = 53, // 0x00000035
    ChineseFullWidth = 54, // 0x00000036
    NativeScript = 55, // 0x00000037
    Text = 57, // 0x00000039
    Chat = 58, // 0x0000003A
    NameOrPhoneNumber = 59, // 0x0000003B
    EmailUserNameOrAddress = 60, // 0x0000003C
    Private = 61, // 0x0000003D
    Maps = 62, // 0x0000003E
    PasswordNumeric = 63, // 0x0000003F
    FormulaNumber = 67, // 0x00000043
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] ChatWithoutEmoji = 68, // 0x00000044
  }
}
