// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardAppletIdGroupRegistration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SmartCardAppletIdGroupRegistration : ISmartCardAppletIdGroupRegistration
  {
    public extern SmartCardAppletIdGroupActivationPolicy ActivationPolicy { [MethodImpl] get; }

    public extern SmartCardAppletIdGroup AppletIdGroup { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardActivationPolicyChangeResult> RequestActivationPolicyChangeAsync(
      SmartCardAppletIdGroupActivationPolicy policy);

    public extern Guid Id { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetAutomaticResponseApdusAsync(
      IIterable<SmartCardAutomaticResponseApdu> apdus);
  }
}
