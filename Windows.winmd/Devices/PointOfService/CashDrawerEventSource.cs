// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.CashDrawerEventSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class CashDrawerEventSource : ICashDrawerEventSource
  {
    public extern event TypedEventHandler<CashDrawerEventSource, CashDrawerClosedEventArgs> DrawerClosed;

    public extern event TypedEventHandler<CashDrawerEventSource, CashDrawerOpenedEventArgs> DrawerOpened;
  }
}
