// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Pnp.IPnpObjectStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration.Pnp
{
  [ExclusiveTo(typeof (PnpObject))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3015911997, 53608, 18016, 187, 243, 167, 51, 177, 75, 110, 1)]
  internal interface IPnpObjectStatics
  {
    IAsyncOperation<PnpObject> CreateFromIdAsync(
      PnpObjectType type,
      string id,
      IIterable<string> requestedProperties);

    [Overload("FindAllAsync")]
    IAsyncOperation<PnpObjectCollection> FindAllAsync(
      PnpObjectType type,
      IIterable<string> requestedProperties);

    [Overload("FindAllAsyncAqsFilter")]
    IAsyncOperation<PnpObjectCollection> FindAllAsync(
      PnpObjectType type,
      IIterable<string> requestedProperties,
      string aqsFilter);

    [Overload("CreateWatcher")]
    PnpObjectWatcher CreateWatcher(
      PnpObjectType type,
      IIterable<string> requestedProperties);

    [Overload("CreateWatcherAqsFilter")]
    PnpObjectWatcher CreateWatcher(
      PnpObjectType type,
      IIterable<string> requestedProperties,
      string aqsFilter);
  }
}
