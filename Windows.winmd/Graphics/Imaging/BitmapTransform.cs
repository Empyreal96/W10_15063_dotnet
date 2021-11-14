// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapTransform
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BitmapTransform : IBitmapTransform
  {
    [MethodImpl]
    public extern BitmapTransform();

    public extern uint ScaledWidth { [MethodImpl] get; [MethodImpl] set; }

    public extern uint ScaledHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern BitmapInterpolationMode InterpolationMode { [MethodImpl] get; [MethodImpl] set; }

    public extern BitmapFlip Flip { [MethodImpl] get; [MethodImpl] set; }

    public extern BitmapRotation Rotation { [MethodImpl] get; [MethodImpl] set; }

    public extern BitmapBounds Bounds { [MethodImpl] get; [MethodImpl] set; }
  }
}
