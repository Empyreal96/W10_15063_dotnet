// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTaskRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Muse(Version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PrintTaskRequest : IPrintTaskRequest
  {
    public extern DateTime Deadline { [MethodImpl] get; }

    [MethodImpl]
    public extern PrintTask CreatePrintTask(
      string title,
      PrintTaskSourceRequestedHandler handler);

    [MethodImpl]
    public extern PrintTaskRequestedDeferral GetDeferral();
  }
}
