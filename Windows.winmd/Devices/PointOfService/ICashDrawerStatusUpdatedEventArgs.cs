// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICashDrawerStatusUpdatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (CashDrawerStatusUpdatedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(816507274, 3440, 17820, 149, 83, 135, 225, 36, 197, 36, 136)]
  internal interface ICashDrawerStatusUpdatedEventArgs
  {
    CashDrawerStatus Status { get; }
  }
}
