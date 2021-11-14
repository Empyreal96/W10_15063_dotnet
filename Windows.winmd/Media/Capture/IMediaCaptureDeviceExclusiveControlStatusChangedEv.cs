// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [Guid(2637140493, 42376, 17350, 137, 214, 90, 211, 34, 175, 0, 106)]
  [ExclusiveTo(typeof (MediaCaptureDeviceExclusiveControlStatusChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs
  {
    string DeviceId { get; }

    MediaCaptureDeviceExclusiveControlStatus Status { get; }
  }
}
