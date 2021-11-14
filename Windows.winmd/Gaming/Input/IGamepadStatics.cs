// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IGamepadStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [Guid(2344412457, 54428, 14825, 149, 96, 228, 125, 222, 150, 183, 200)]
  [ExclusiveTo(typeof (Gamepad))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGamepadStatics
  {
    event EventHandler<Gamepad> GamepadAdded;

    event EventHandler<Gamepad> GamepadRemoved;

    IVectorView<Gamepad> Gamepads { get; }
  }
}
