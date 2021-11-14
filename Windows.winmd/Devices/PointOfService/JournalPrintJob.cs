// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.JournalPrintJob
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class JournalPrintJob : IPosPrinterJob
  {
    [MethodImpl]
    public extern void Print(string data);

    [Overload("PrintLine")]
    [MethodImpl]
    public extern void PrintLine(string data);

    [Overload("PrintNewline")]
    [MethodImpl]
    public extern void PrintLine();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ExecuteAsync();
  }
}
