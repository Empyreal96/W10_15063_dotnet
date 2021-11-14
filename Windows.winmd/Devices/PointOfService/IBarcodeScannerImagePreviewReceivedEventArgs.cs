// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScannerImagePreviewReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4088913541, 28299, 17230, 159, 88, 6, 239, 38, 188, 75, 175)]
  [ExclusiveTo(typeof (BarcodeScannerImagePreviewReceivedEventArgs))]
  internal interface IBarcodeScannerImagePreviewReceivedEventArgs
  {
    IRandomAccessStreamWithContentType Preview { get; }
  }
}
