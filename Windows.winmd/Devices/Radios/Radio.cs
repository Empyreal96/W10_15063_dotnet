// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Radios.Radio
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Radios
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRadioStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Radio : IRadio
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<RadioAccessStatus> SetStateAsync(
      RadioState value);

    public extern event TypedEventHandler<Radio, object> StateChanged;

    public extern RadioState State { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    public extern RadioKind Kind { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<Radio>> GetRadiosAsync();

    [MethodImpl]
    public static extern string GetDeviceSelector();

    [Overload("FromIdAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Radio> FromIdAsync(string deviceId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<RadioAccessStatus> RequestAccessAsync();
  }
}
