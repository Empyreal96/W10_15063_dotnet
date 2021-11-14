// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.GattServiceProviderConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IGattServiceProviderConnectionStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class GattServiceProviderConnection : IGattServiceProviderConnection
  {
    public extern string TriggerId { [MethodImpl] get; }

    public extern GattLocalService Service { [MethodImpl] get; }

    [MethodImpl]
    public extern void Start();

    public static extern IMapView<string, GattServiceProviderConnection> AllServices { [MethodImpl] get; }
  }
}
