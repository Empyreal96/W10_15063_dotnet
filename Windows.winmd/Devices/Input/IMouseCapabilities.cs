// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IMouseCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [ExclusiveTo(typeof (MouseCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3164987427, 32217, 19307, 154, 146, 85, 212, 60, 179, 143, 115)]
  internal interface IMouseCapabilities
  {
    int MousePresent { get; }

    int VerticalWheelPresent { get; }

    int HorizontalWheelPresent { get; }

    int SwapButtons { get; }

    uint NumberOfButtons { get; }
  }
}
