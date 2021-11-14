// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskOptionsCoreUIConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1659280931, 39454, 17206, 183, 79, 60, 199, 244, 207, 247, 9)]
  public interface IPrintTaskOptionsCoreUIConfiguration
  {
    IVector<string> DisplayedOptions { get; }
  }
}
