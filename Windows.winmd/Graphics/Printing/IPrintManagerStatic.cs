// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintManagerStatic
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1477991885, 58932, 18004, 132, 240, 224, 21, 42, 130, 23, 172)]
  [ExclusiveTo(typeof (PrintManager))]
  internal interface IPrintManagerStatic
  {
    PrintManager GetForCurrentView();

    [RemoteAsync]
    IAsyncOperation<bool> ShowPrintUIAsync();
  }
}
