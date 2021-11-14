// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Pnp.PnpObject
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration.Pnp
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPnpObjectStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PnpObject : IPnpObject
  {
    public extern PnpObjectType Type { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }

    public extern IMapView<string, object> Properties { [MethodImpl] [return: HasVariant] get; }

    [MethodImpl]
    public extern void Update(PnpObjectUpdate updateInfo);

    [MethodImpl]
    public static extern IAsyncOperation<PnpObject> CreateFromIdAsync(
      PnpObjectType type,
      string id,
      IIterable<string> requestedProperties);

    [Overload("FindAllAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<PnpObjectCollection> FindAllAsync(
      PnpObjectType type,
      IIterable<string> requestedProperties);

    [Overload("FindAllAsyncAqsFilter")]
    [MethodImpl]
    public static extern IAsyncOperation<PnpObjectCollection> FindAllAsync(
      PnpObjectType type,
      IIterable<string> requestedProperties,
      string aqsFilter);

    [Overload("CreateWatcher")]
    [MethodImpl]
    public static extern PnpObjectWatcher CreateWatcher(
      PnpObjectType type,
      IIterable<string> requestedProperties);

    [Overload("CreateWatcherAqsFilter")]
    [MethodImpl]
    public static extern PnpObjectWatcher CreateWatcher(
      PnpObjectType type,
      IIterable<string> requestedProperties,
      string aqsFilter);
  }
}
