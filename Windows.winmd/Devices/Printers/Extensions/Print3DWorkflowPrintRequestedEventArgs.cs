// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.Extensions.Print3DWorkflowPrintRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers.Extensions
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class Print3DWorkflowPrintRequestedEventArgs : 
    IPrint3DWorkflowPrintRequestedEventArgs
  {
    public extern Print3DWorkflowStatus Status { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetExtendedStatus(Print3DWorkflowDetail value);

    [MethodImpl]
    public extern void SetSource(object source);

    [MethodImpl]
    public extern void SetSourceChanged(bool value);
  }
}
