// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardProvisioningStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmartCardProvisioning))]
  [Guid(327690312, 3347, 20080, 151, 53, 81, 218, 236, 165, 37, 79)]
  internal interface ISmartCardProvisioningStatics
  {
    [RemoteAsync]
    IAsyncOperation<SmartCardProvisioning> FromSmartCardAsync(
      SmartCard card);

    [Overload("RequestVirtualSmartCardCreationAsync")]
    IAsyncOperation<SmartCardProvisioning> RequestVirtualSmartCardCreationAsync(
      string friendlyName,
      IBuffer administrativeKey,
      SmartCardPinPolicy pinPolicy);

    [Overload("RequestVirtualSmartCardCreationAsyncWithCardId")]
    IAsyncOperation<SmartCardProvisioning> RequestVirtualSmartCardCreationAsync(
      string friendlyName,
      IBuffer administrativeKey,
      SmartCardPinPolicy pinPolicy,
      Guid cardId);

    IAsyncOperation<bool> RequestVirtualSmartCardDeletionAsync(SmartCard card);
  }
}
