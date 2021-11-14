// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IStatusChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ExclusiveTo(typeof (StatusChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(877908698, 35987, 16657, 162, 5, 154, 236, 252, 155, 229, 192)]
  internal interface IStatusChangedEventArgs
  {
    PositionStatus Status { get; }
  }
}
