// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ImageCue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.Core
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772160)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ImageCue : IImageCue, IMediaCue
  {
    [MethodImpl]
    public extern ImageCue();

    public extern TimedTextPoint Position { [MethodImpl] get; [MethodImpl] set; }

    public extern TimedTextSize Extent { [MethodImpl] get; [MethodImpl] set; }

    public extern SoftwareBitmap SoftwareBitmap { [MethodImpl] set; [MethodImpl] get; }

    public extern TimeSpan StartTime { [MethodImpl] set; [MethodImpl] get; }

    public extern TimeSpan Duration { [MethodImpl] set; [MethodImpl] get; }

    public extern string Id { [MethodImpl] set; [MethodImpl] get; }
  }
}
