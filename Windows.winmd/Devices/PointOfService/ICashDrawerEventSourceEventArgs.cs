// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICashDrawerEventSourceEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1774926785, 5247, 16924, 156, 35, 9, 1, 35, 187, 120, 108)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ICashDrawerEventSourceEventArgs
  {
    CashDrawer CashDrawer { get; }
  }
}
