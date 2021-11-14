// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DragUIOverride
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml.Media.Imaging;

namespace Windows.UI.Xaml
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DragUIOverride : IDragUIOverride
  {
    public extern string Caption { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsContentVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCaptionVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsGlyphVisible { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void Clear();

    [Overload("SetContentFromBitmapImage")]
    [MethodImpl]
    public extern void SetContentFromBitmapImage(BitmapImage bitmapImage);

    [Overload("SetContentFromBitmapImageWithAnchorPoint")]
    [MethodImpl]
    public extern void SetContentFromBitmapImage(BitmapImage bitmapImage, Point anchorPoint);

    [Overload("SetContentFromSoftwareBitmap")]
    [MethodImpl]
    public extern void SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap);

    [Overload("SetContentFromSoftwareBitmapWithAnchorPoint")]
    [MethodImpl]
    public extern void SetContentFromSoftwareBitmap(
      SoftwareBitmap softwareBitmap,
      Point anchorPoint);
  }
}
