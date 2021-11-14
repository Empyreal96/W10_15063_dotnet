// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumberParser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3865416722, 18963, 19027, 131, 161, 57, 47, 190, 76, 255, 159)]
  public interface INumberParser
  {
    IReference<long> ParseInt(string text);

    IReference<ulong> ParseUInt(string text);

    IReference<double> ParseDouble(string text);
  }
}
