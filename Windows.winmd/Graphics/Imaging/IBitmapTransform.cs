// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapTransform
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [Guid(2926924612, 57960, 19765, 173, 207, 233, 149, 211, 26, 141, 52)]
  [ExclusiveTo(typeof (BitmapTransform))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBitmapTransform
  {
    uint ScaledWidth { get; set; }

    uint ScaledHeight { get; set; }

    BitmapInterpolationMode InterpolationMode { get; set; }

    BitmapFlip Flip { get; set; }

    BitmapRotation Rotation { get; set; }

    BitmapBounds Bounds { get; set; }
  }
}
