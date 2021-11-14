﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.VibrationDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772163)]
  [Static(typeof (IVibrationDeviceStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VibrationDevice : IVibrationDevice
  {
    public extern string Id { [MethodImpl] get; }

    public extern SimpleHapticsController SimpleHapticsController { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<VibrationAccessStatus> RequestAccessAsync();

    [MethodImpl]
    public static extern string GetDeviceSelector();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<VibrationDevice> FromIdAsync(
      string deviceId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<VibrationDevice> GetDefaultAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<VibrationDevice>> FindAllAsync();
  }
}
