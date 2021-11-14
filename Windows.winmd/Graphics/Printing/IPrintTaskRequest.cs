// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Guid(1878400558, 10018, 16960, 166, 124, 243, 100, 132, 154, 23, 243)]
  [ExclusiveTo(typeof (PrintTaskRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPrintTaskRequest
  {
    DateTime Deadline { get; }

    PrintTask CreatePrintTask(string title, PrintTaskSourceRequestedHandler handler);

    PrintTaskRequestedDeferral GetDeferral();
  }
}
