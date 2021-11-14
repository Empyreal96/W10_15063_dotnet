// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.PhoneNumberFormatter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPhoneNumberFormatterStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PhoneNumberFormatter : IPhoneNumberFormatter
  {
    [MethodImpl]
    public extern PhoneNumberFormatter();

    [Overload("Format")]
    [MethodImpl]
    public extern string Format(PhoneNumberInfo number);

    [Overload("FormatWithOutputFormat")]
    [MethodImpl]
    public extern string Format(PhoneNumberInfo number, PhoneNumberFormat numberFormat);

    [MethodImpl]
    public extern string FormatPartialString(string number);

    [MethodImpl]
    public extern string FormatString(string number);

    [MethodImpl]
    public extern string FormatStringWithLeftToRightMarkers(string number);

    [MethodImpl]
    public static extern void TryCreate(string regionCode, out PhoneNumberFormatter phoneNumber);

    [MethodImpl]
    public static extern int GetCountryCodeForRegion(string regionCode);

    [MethodImpl]
    public static extern string GetNationalDirectDialingPrefixForRegion(
      string regionCode,
      bool stripNonDigit);

    [MethodImpl]
    public static extern string WrapWithLeftToRightMarkers(string number);
  }
}
