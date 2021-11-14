// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.Extensions.Print3DWorkflow
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers.Extensions
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Print3DWorkflow : IPrint3DWorkflow, IPrint3DWorkflow2
  {
    public extern string DeviceID { [MethodImpl] get; }

    [MethodImpl]
    public extern object GetPrintModelPackage();

    public extern bool IsPrintReady { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<Print3DWorkflow, Print3DWorkflowPrintRequestedEventArgs> PrintRequested;

    public extern event TypedEventHandler<Print3DWorkflow, Print3DWorkflowPrinterChangedEventArgs> PrinterChanged;
  }
}
