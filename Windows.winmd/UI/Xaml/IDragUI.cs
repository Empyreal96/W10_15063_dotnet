// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDragUI
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml.Media.Imaging;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DragUI))]
  [WebHostHidden]
  [Guid(765188152, 31840, 18498, 145, 112, 52, 111, 225, 10, 34, 106)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDragUI
  {
    [Overload("SetContentFromBitmapImage")]
    void SetContentFromBitmapImage(BitmapImage bitmapImage);

    [Overload("SetContentFromBitmapImageWithAnchorPoint")]
    void SetContentFromBitmapImage(BitmapImage bitmapImage, Point anchorPoint);

    [Overload("SetContentFromSoftwareBitmap")]
    void SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap);

    [Overload("SetContentFromSoftwareBitmapWithAnchorPoint")]
    void SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap, Point anchorPoint);

    void SetContentFromDataPackage();
  }
}
