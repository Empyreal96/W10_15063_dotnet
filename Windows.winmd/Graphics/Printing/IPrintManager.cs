// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PrintManager))]
  [Guid(4280981140, 35993, 17661, 174, 74, 25, 217, 170, 154, 15, 10)]
  internal interface IPrintManager
  {
    event TypedEventHandler<PrintManager, PrintTaskRequestedEventArgs> PrintTaskRequested;
  }
}
