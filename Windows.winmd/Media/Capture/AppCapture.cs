// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.AppCapture
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [Static(typeof (IAppCaptureStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class AppCapture : IAppCapture
  {
    public extern bool IsCapturingAudio { [MethodImpl] get; }

    public extern bool IsCapturingVideo { [MethodImpl] get; }

    public extern event TypedEventHandler<AppCapture, object> CapturingChanged;

    [MethodImpl]
    public static extern AppCapture GetForCurrentView();
  }
}
