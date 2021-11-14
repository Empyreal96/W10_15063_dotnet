// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardTriggerDetails2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Guid(692438377, 35189, 19025, 158, 26, 95, 138, 118, 238, 81, 175)]
  [ExclusiveTo(typeof (SmartCardTriggerDetails))]
  [ContractVersion(typeof (SmartCardBackgroundTriggerContract), 65536)]
  internal interface ISmartCardTriggerDetails2
  {
    SmartCardEmulator Emulator { get; }

    [RemoteAsync]
    [Overload("TryLaunchCurrentAppAsync")]
    IAsyncOperation<bool> TryLaunchCurrentAppAsync(string arguments);

    [Overload("TryLaunchCurrentAppWithBehaviorAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryLaunchCurrentAppAsync(
      string arguments,
      SmartCardLaunchBehavior behavior);
  }
}
