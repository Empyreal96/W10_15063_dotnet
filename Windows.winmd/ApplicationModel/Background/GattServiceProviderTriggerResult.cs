// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.GattServiceProviderTriggerResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class GattServiceProviderTriggerResult : IGattServiceProviderTriggerResult
  {
    public extern GattServiceProviderTrigger Trigger { [MethodImpl] get; }

    public extern BluetoothError Error { [MethodImpl] get; }
  }
}
