// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardEmulator2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Guid(4265590968, 34089, 16666, 128, 123, 72, 237, 194, 160, 171, 68)]
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  [ExclusiveTo(typeof (SmartCardEmulator))]
  internal interface ISmartCardEmulator2
  {
    event TypedEventHandler<SmartCardEmulator, SmartCardEmulatorApduReceivedEventArgs> ApduReceived;

    event TypedEventHandler<SmartCardEmulator, SmartCardEmulatorConnectionDeactivatedEventArgs> ConnectionDeactivated;

    void Start();

    bool IsHostCardEmulationSupported();
  }
}
