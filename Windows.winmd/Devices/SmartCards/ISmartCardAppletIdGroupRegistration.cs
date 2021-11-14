// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardAppletIdGroupRegistration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  [Guid(3742501073, 12731, 21910, 67, 177, 109, 105, 160, 37, 123, 58)]
  [ExclusiveTo(typeof (SmartCardAppletIdGroupRegistration))]
  internal interface ISmartCardAppletIdGroupRegistration
  {
    SmartCardAppletIdGroupActivationPolicy ActivationPolicy { get; }

    SmartCardAppletIdGroup AppletIdGroup { get; }

    [RemoteAsync]
    IAsyncOperation<SmartCardActivationPolicyChangeResult> RequestActivationPolicyChangeAsync(
      SmartCardAppletIdGroupActivationPolicy policy);

    Guid Id { get; }

    [RemoteAsync]
    IAsyncAction SetAutomaticResponseApdusAsync(
      IIterable<SmartCardAutomaticResponseApdu> apdus);
  }
}
