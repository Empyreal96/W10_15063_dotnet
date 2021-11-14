// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.ISoftwareBitmapFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ExclusiveTo(typeof (SoftwareBitmap))]
  [Guid(3382700905, 11618, 19783, 166, 179, 79, 219, 106, 7, 253, 248)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISoftwareBitmapFactory
  {
    SoftwareBitmap Create(BitmapPixelFormat format, int width, int height);

    SoftwareBitmap CreateWithAlpha(
      BitmapPixelFormat format,
      int width,
      int height,
      BitmapAlphaMode alpha);
  }
}
