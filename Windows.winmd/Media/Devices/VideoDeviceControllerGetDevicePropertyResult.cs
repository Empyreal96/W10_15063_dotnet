// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.VideoDeviceControllerGetDevicePropertyResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772163)]
  public sealed class VideoDeviceControllerGetDevicePropertyResult : 
    IVideoDeviceControllerGetDevicePropertyResult
  {
    public extern VideoDeviceControllerGetDevicePropertyStatus Status { [MethodImpl] get; }

    public extern object Value { [MethodImpl] [return: Variant] get; }
  }
}
