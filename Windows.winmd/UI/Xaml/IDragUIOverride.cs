// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDragUIOverride
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml.Media.Imaging;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DragUIOverride))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3178012154, 51553, 18529, 183, 165, 191, 79, 228, 168, 166, 239)]
  internal interface IDragUIOverride
  {
    string Caption { get; set; }

    bool IsContentVisible { get; set; }

    bool IsCaptionVisible { get; set; }

    bool IsGlyphVisible { get; set; }

    void Clear();

    [Overload("SetContentFromBitmapImage")]
    void SetContentFromBitmapImage(BitmapImage bitmapImage);

    [Overload("SetContentFromBitmapImageWithAnchorPoint")]
    void SetContentFromBitmapImage(BitmapImage bitmapImage, Point anchorPoint);

    [Overload("SetContentFromSoftwareBitmap")]
    void SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap);

    [Overload("SetContentFromSoftwareBitmapWithAnchorPoint")]
    void SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap, Point anchorPoint);
  }
}
