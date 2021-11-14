// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinterStatusUpdatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PosPrinterStatusUpdatedEventArgs))]
  [Guid(786139103, 5030, 17037, 186, 129, 176, 231, 195, 229, 163, 205)]
  internal interface IPosPrinterStatusUpdatedEventArgs
  {
    PosPrinterStatus Status { get; }
  }
}
