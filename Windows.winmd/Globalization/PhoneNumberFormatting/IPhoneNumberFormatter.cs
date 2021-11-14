// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.IPhoneNumberFormatter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(358003870, 47828, 19274, 144, 13, 68, 7, 173, 183, 201, 129)]
  [ExclusiveTo(typeof (PhoneNumberFormatter))]
  internal interface IPhoneNumberFormatter
  {
    [Overload("Format")]
    string Format(PhoneNumberInfo number);

    [Overload("FormatWithOutputFormat")]
    string Format(PhoneNumberInfo number, PhoneNumberFormat numberFormat);

    string FormatPartialString(string number);

    string FormatString(string number);

    string FormatStringWithLeftToRightMarkers(string number);
  }
}
