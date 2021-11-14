// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.MediaOverlay
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Editing
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [GCPressure(amount = GCPressureAmount.High)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IMediaOverlayFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MediaOverlay : IMediaOverlay
  {
    [MethodImpl]
    public extern MediaOverlay(MediaClip clip);

    [MethodImpl]
    public extern MediaOverlay(MediaClip clip, Rect position, double opacity);

    public extern Rect Position { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan Delay { [MethodImpl] set; [MethodImpl] get; }

    public extern double Opacity { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern MediaOverlay Clone();

    public extern MediaClip Clip { [MethodImpl] get; }

    public extern bool AudioEnabled { [MethodImpl] get; [MethodImpl] set; }
  }
}
