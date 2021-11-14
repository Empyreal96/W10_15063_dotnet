// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.IPhoneNumberInfoFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  [ExclusiveTo(typeof (PhoneNumberInfo))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2181216612, 44458, 19711, 143, 207, 23, 231, 81, 106, 40, 255)]
  internal interface IPhoneNumberInfoFactory
  {
    PhoneNumberInfo Create(string number);
  }
}
