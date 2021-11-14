// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IVideoDeviceControllerGetDevicePropertyResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (VideoDeviceControllerGetDevicePropertyResult))]
  [Guid(3319301013, 28373, 18320, 139, 93, 14, 241, 57, 53, 208, 248)]
  internal interface IVideoDeviceControllerGetDevicePropertyResult
  {
    VideoDeviceControllerGetDevicePropertyStatus Status { get; }

    object Value { [return: Variant] get; }
  }
}
