// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardEmulatorStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ExclusiveTo(typeof (SmartCardEmulator))]
  [Guid(1773051786, 46965, 18571, 132, 54, 108, 30, 40, 237, 115, 31)]
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  internal interface ISmartCardEmulatorStatics2
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<SmartCardAppletIdGroupRegistration>> GetAppletIdGroupRegistrationsAsync();

    [RemoteAsync]
    IAsyncOperation<SmartCardAppletIdGroupRegistration> RegisterAppletIdGroupAsync(
      SmartCardAppletIdGroup appletIdGroup);

    [RemoteAsync]
    IAsyncAction UnregisterAppletIdGroupAsync(
      SmartCardAppletIdGroupRegistration registration);

    ushort MaxAppletIdGroupRegistrations { get; }
  }
}
