// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.PhoneNumberInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  [Activatable(typeof (IPhoneNumberInfoFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPhoneNumberInfoStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class PhoneNumberInfo : IPhoneNumberInfo, IStringable
  {
    [MethodImpl]
    public extern PhoneNumberInfo(string number);

    public extern int CountryCode { [MethodImpl] get; }

    public extern string PhoneNumber { [MethodImpl] get; }

    [MethodImpl]
    public extern int GetLengthOfGeographicalAreaCode();

    [MethodImpl]
    public extern string GetNationalSignificantNumber();

    [MethodImpl]
    public extern int GetLengthOfNationalDestinationCode();

    [MethodImpl]
    public extern PredictedPhoneNumberKind PredictNumberKind();

    [MethodImpl]
    public extern string GetGeographicRegionCode();

    [MethodImpl]
    public extern PhoneNumberMatchResult CheckNumberMatch(
      PhoneNumberInfo otherNumber);

    [MethodImpl]
    public new extern string ToString();

    [Overload("TryParse")]
    [MethodImpl]
    public static extern PhoneNumberParseResult TryParse(
      string input,
      out PhoneNumberInfo phoneNumber);

    [Overload("TryParseWithRegion")]
    [MethodImpl]
    public static extern PhoneNumberParseResult TryParse(
      string input,
      string regionCode,
      out PhoneNumberInfo phoneNumber);
  }
}
