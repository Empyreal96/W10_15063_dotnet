// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.Extensions.IPrint3DWorkflowPrinterChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers.Extensions
{
  [ExclusiveTo(typeof (Print3DWorkflowPrinterChangedEventArgs))]
  [Guid(1159881730, 38396, 18503, 147, 179, 19, 77, 191, 92, 96, 247)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPrint3DWorkflowPrinterChangedEventArgs
  {
    string NewDeviceId { get; }
  }
}
