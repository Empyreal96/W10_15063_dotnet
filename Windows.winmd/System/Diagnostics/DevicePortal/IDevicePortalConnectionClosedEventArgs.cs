// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DevicePortal.IDevicePortalConnectionClosedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.DevicePortal
{
  [ExclusiveTo(typeof (DevicePortalConnectionClosedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4244049464, 28722, 17036, 159, 80, 148, 92, 21, 169, 240, 203)]
  internal interface IDevicePortalConnectionClosedEventArgs
  {
    DevicePortalConnectionClosedReason Reason { get; }
  }
}
