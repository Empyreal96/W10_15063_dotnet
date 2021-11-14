// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.OptionDetails.IPrintTextOptionDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.OptionDetails
{
  [Guid(2910184803, 23780, 18108, 153, 24, 171, 159, 173, 20, 76, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IPrintTextOptionDetails : IPrintOptionDetails
  {
    uint MaxCharacters { get; }
  }
}
