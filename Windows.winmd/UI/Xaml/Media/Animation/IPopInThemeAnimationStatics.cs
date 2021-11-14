// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPopInThemeAnimationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4020935123, 8586, 18177, 151, 127, 241, 191, 174, 139, 166, 73)]
  [ExclusiveTo(typeof (PopInThemeAnimation))]
  internal interface IPopInThemeAnimationStatics
  {
    DependencyProperty TargetNameProperty { get; }

    DependencyProperty FromHorizontalOffsetProperty { get; }

    DependencyProperty FromVerticalOffsetProperty { get; }
  }
}
