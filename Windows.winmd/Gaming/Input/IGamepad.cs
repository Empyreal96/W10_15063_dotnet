// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IGamepad
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ExclusiveTo(typeof (Gamepad))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3162223676, 2665, 14595, 158, 157, 165, 15, 134, 164, 93, 229)]
  internal interface IGamepad : IGameController
  {
    GamepadVibration Vibration { get; set; }

    GamepadReading GetCurrentReading();
  }
}
