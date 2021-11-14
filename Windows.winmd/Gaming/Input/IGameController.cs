// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IGameController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(464479522, 24420, 17093, 130, 103, 185, 254, 34, 21, 191, 189)]
  public interface IGameController
  {
    event TypedEventHandler<IGameController, Headset> HeadsetConnected;

    event TypedEventHandler<IGameController, Headset> HeadsetDisconnected;

    event TypedEventHandler<IGameController, UserChangedEventArgs> UserChanged;

    Headset Headset { get; }

    bool IsWireless { get; }

    User User { get; }
  }
}
