// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IScreenCapture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;
using Windows.Phone;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(2300026615, 52498, 19982, 166, 212, 91, 61, 233, 139, 46, 155)]
  [ExclusiveTo(typeof (ScreenCapture))]
  internal interface IScreenCapture
  {
    IMediaSource AudioSource { get; }

    IMediaSource VideoSource { get; }

    bool IsAudioSuspended { get; }

    bool IsVideoSuspended { get; }

    event TypedEventHandler<ScreenCapture, SourceSuspensionChangedEventArgs> SourceSuspensionChanged;
  }
}
