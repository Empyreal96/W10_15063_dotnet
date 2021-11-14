// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardBackgroundTriggerContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SmartCardTriggerDetails : 
    ISmartCardTriggerDetails,
    ISmartCardTriggerDetails2,
    ISmartCardTriggerDetails3
  {
    public extern SmartCardTriggerType TriggerType { [MethodImpl] get; }

    public extern IBuffer SourceAppletId { [MethodImpl] get; }

    public extern IBuffer TriggerData { [MethodImpl] get; }

    public extern SmartCardEmulator Emulator { [MethodImpl] get; }

    [Overload("TryLaunchCurrentAppAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryLaunchCurrentAppAsync(string arguments);

    [Overload("TryLaunchCurrentAppWithBehaviorAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryLaunchCurrentAppAsync(
      string arguments,
      SmartCardLaunchBehavior behavior);

    public extern SmartCard SmartCard { [MethodImpl] get; }
  }
}
