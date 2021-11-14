// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.IPhoneNumberFormatterStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  [Guid(1554446641, 34009, 16715, 171, 78, 160, 85, 44, 135, 134, 2)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (PhoneNumberFormatter))]
  internal interface IPhoneNumberFormatterStatics
  {
    void TryCreate(string regionCode, out PhoneNumberFormatter phoneNumber);

    int GetCountryCodeForRegion(string regionCode);

    string GetNationalDirectDialingPrefixForRegion(string regionCode, bool stripNonDigit);

    string WrapWithLeftToRightMarkers(string number);
  }
}
