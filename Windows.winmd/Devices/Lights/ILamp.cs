// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.ILamp
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Lights
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(75324314, 59973, 19243, 177, 162, 20, 223, 240, 11, 222, 123)]
  [ExclusiveTo(typeof (Lamp))]
  internal interface ILamp : IClosable
  {
    string DeviceId { get; }

    bool IsEnabled { get; set; }

    float BrightnessLevel { get; set; }

    bool IsColorSettable { get; }

    Color Color { get; set; }

    event TypedEventHandler<Lamp, LampAvailabilityChangedEventArgs> AvailabilityChanged;
  }
}
