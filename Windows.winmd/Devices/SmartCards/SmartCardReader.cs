// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISmartCardReaderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SmartCardReader : ISmartCardReader
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    public extern SmartCardReaderKind Kind { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardReaderStatus> GetStatusAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<SmartCard>> FindAllCardsAsync();

    public extern event TypedEventHandler<SmartCardReader, CardAddedEventArgs> CardAdded;

    public extern event TypedEventHandler<SmartCardReader, CardRemovedEventArgs> CardRemoved;

    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector();

    [Overload("GetDeviceSelectorWithKind")]
    [MethodImpl]
    public static extern string GetDeviceSelector(SmartCardReaderKind kind);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SmartCardReader> FromIdAsync(
      string deviceId);
  }
}
