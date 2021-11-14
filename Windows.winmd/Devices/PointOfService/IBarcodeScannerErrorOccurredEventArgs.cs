// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScannerErrorOccurredEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(751984687, 53050, 16386, 167, 90, 197, 236, 70, 143, 10, 32)]
  [ExclusiveTo(typeof (BarcodeScannerErrorOccurredEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBarcodeScannerErrorOccurredEventArgs
  {
    BarcodeScannerReport PartialInputData { get; }

    bool IsRetriable { get; }

    UnifiedPosErrorData ErrorData { get; }
  }
}
