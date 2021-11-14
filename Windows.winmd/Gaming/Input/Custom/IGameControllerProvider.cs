// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IGameControllerProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [Guid(3872864642, 10646, 17753, 177, 108, 62, 87, 212, 110, 88, 214)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface IGameControllerProvider
  {
    GameControllerVersionInfo FirmwareVersionInfo { get; }

    ushort HardwareProductId { get; }

    ushort HardwareVendorId { get; }

    GameControllerVersionInfo HardwareVersionInfo { get; }

    bool IsConnected { get; }
  }
}
