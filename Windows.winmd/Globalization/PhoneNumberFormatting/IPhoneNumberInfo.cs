// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.IPhoneNumberInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  [ExclusiveTo(typeof (PhoneNumberInfo))]
  [Guid(477947101, 51380, 20131, 154, 239, 179, 66, 226, 197, 180, 23)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPhoneNumberInfo
  {
    int CountryCode { get; }

    string PhoneNumber { get; }

    int GetLengthOfGeographicalAreaCode();

    string GetNationalSignificantNumber();

    int GetLengthOfNationalDestinationCode();

    PredictedPhoneNumberKind PredictNumberKind();

    string GetGeographicRegionCode();

    PhoneNumberMatchResult CheckNumberMatch(PhoneNumberInfo otherNumber);
  }
}
