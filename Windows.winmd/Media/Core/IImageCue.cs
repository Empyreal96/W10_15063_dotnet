// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IImageCue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ImageCue))]
  [Guid(1384284802, 13947, 17419, 145, 22, 60, 132, 87, 13, 210, 112)]
  internal interface IImageCue : IMediaCue
  {
    TimedTextPoint Position { get; set; }

    TimedTextSize Extent { get; set; }

    SoftwareBitmap SoftwareBitmap { set; get; }
  }
}
