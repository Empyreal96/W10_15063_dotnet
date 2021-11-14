// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskProgressingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ExclusiveTo(typeof (PrintTaskProgressingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2165101515, 46096, 17026, 160, 115, 90, 195, 120, 35, 65, 116)]
  internal interface IPrintTaskProgressingEventArgs
  {
    uint DocumentPageCount { get; }
  }
}
