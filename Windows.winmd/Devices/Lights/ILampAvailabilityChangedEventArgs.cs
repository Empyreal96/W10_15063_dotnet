// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.ILampAvailabilityChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LampAvailabilityChangedEventArgs))]
  [Guid(1332624877, 1954, 18845, 146, 96, 103, 227, 4, 83, 43, 164)]
  internal interface ILampAvailabilityChangedEventArgs
  {
    bool IsAvailable { get; }
  }
}
