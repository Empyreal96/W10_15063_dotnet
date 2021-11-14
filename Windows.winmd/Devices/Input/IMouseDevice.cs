// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IMouseDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MouseDevice))]
  [Guid(2297295960, 62152, 18932, 190, 31, 194, 86, 179, 136, 188, 17)]
  internal interface IMouseDevice
  {
    event TypedEventHandler<MouseDevice, MouseEventArgs> MouseMoved;
  }
}
