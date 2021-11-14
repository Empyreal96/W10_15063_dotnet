// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IContentThemeTransitionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(244245381, 39490, 17497, 175, 169, 51, 125, 196, 30, 21, 135)]
  [ExclusiveTo(typeof (ContentThemeTransition))]
  internal interface IContentThemeTransitionStatics
  {
    DependencyProperty HorizontalOffsetProperty { get; }

    DependencyProperty VerticalOffsetProperty { get; }
  }
}
