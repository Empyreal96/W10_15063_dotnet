// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardEmulator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  [Static(typeof (ISmartCardEmulatorStatics2), 65536, "Windows.Devices.SmartCards.SmartCardEmulatorContract")]
  [Static(typeof (ISmartCardEmulatorStatics), 65536, "Windows.Devices.SmartCards.SmartCardEmulatorContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class SmartCardEmulator : ISmartCardEmulator, ISmartCardEmulator2
  {
    public extern SmartCardEmulatorEnablementPolicy EnablementPolicy { [MethodImpl] get; }

    public extern event TypedEventHandler<SmartCardEmulator, SmartCardEmulatorApduReceivedEventArgs> ApduReceived;

    public extern event TypedEventHandler<SmartCardEmulator, SmartCardEmulatorConnectionDeactivatedEventArgs> ConnectionDeactivated;

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern bool IsHostCardEmulationSupported();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<SmartCardAppletIdGroupRegistration>> GetAppletIdGroupRegistrationsAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SmartCardAppletIdGroupRegistration> RegisterAppletIdGroupAsync(
      SmartCardAppletIdGroup appletIdGroup);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction UnregisterAppletIdGroupAsync(
      SmartCardAppletIdGroupRegistration registration);

    public static extern ushort MaxAppletIdGroupRegistrations { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SmartCardEmulator> GetDefaultAsync();
  }
}
