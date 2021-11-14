// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.Extensions.IPrint3DWorkflow2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers.Extensions
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2728838479, 35521, 18712, 151, 65, 227, 79, 48, 4, 35, 158)]
  [ExclusiveTo(typeof (Print3DWorkflow))]
  internal interface IPrint3DWorkflow2
  {
    event TypedEventHandler<Print3DWorkflow, Print3DWorkflowPrinterChangedEventArgs> PrinterChanged;
  }
}
