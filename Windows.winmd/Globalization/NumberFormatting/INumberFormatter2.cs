// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumberFormatter2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [Guid(3567829488, 32976, 19213, 168, 158, 136, 44, 30, 143, 131, 16)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INumberFormatter2
  {
    string FormatInt(long value);

    string FormatUInt(ulong value);

    string FormatDouble(double value);
  }
}
