// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumberFormatter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [Guid(2768272457, 30326, 19895, 134, 49, 27, 111, 242, 101, 202, 169)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INumberFormatter
  {
    [Overload("FormatInt")]
    string Format(long value);

    [Overload("FormatUInt")]
    string Format(ulong value);

    [DefaultOverload]
    [Overload("FormatDouble")]
    string Format(double value);
  }
}
