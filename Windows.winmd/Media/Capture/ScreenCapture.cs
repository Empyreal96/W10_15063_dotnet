// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ScreenCapture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;
using Windows.Phone;

namespace Windows.Media.Capture
{
  [Static(typeof (IScreenCaptureStatics), 65536, "Windows.Phone.PhoneContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  public sealed class ScreenCapture : IScreenCapture
  {
    public extern IMediaSource AudioSource { [MethodImpl] get; }

    public extern IMediaSource VideoSource { [MethodImpl] get; }

    public extern bool IsAudioSuspended { [MethodImpl] get; }

    public extern bool IsVideoSuspended { [MethodImpl] get; }

    public extern event TypedEventHandler<ScreenCapture, SourceSuspensionChangedEventArgs> SourceSuspensionChanged;

    [MethodImpl]
    public static extern ScreenCapture GetForCurrentView();
  }
}
