// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.ISignificantDigitsOption
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [Guid(491650269, 11587, 20200, 187, 241, 193, 178, 106, 113, 26, 88)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ISignificantDigitsOption
  {
    int SignificantDigits { get; set; }
  }
}
