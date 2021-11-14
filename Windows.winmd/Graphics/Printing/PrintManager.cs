// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [Muse(Version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPrintManagerStatic2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPrintManagerStatic), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PrintManager : IPrintManager
  {
    public extern event TypedEventHandler<PrintManager, PrintTaskRequestedEventArgs> PrintTaskRequested;

    [MethodImpl]
    public static extern bool IsSupported();

    [MethodImpl]
    public static extern PrintManager GetForCurrentView();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> ShowPrintUIAsync();
  }
}
