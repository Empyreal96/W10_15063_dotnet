// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.IPhoneNumberInfoStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1530875754, 34473, 16617, 134, 73, 109, 97, 22, 25, 40, 212)]
  [ExclusiveTo(typeof (PhoneNumberInfo))]
  internal interface IPhoneNumberInfoStatics
  {
    [Overload("TryParse")]
    PhoneNumberParseResult TryParse(
      string input,
      out PhoneNumberInfo phoneNumber);

    [Overload("TryParseWithRegion")]
    PhoneNumberParseResult TryParse(
      string input,
      string regionCode,
      out PhoneNumberInfo phoneNumber);
  }
}
