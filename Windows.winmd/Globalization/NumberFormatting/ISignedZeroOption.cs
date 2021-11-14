// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.ISignedZeroOption
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4246527281, 2620, 18884, 166, 66, 150, 161, 86, 79, 79, 48)]
  public interface ISignedZeroOption
  {
    bool IsZeroSigned { get; set; }
  }
}
