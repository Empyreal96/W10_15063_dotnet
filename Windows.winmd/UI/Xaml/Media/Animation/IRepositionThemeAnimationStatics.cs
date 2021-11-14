// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IRepositionThemeAnimationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (RepositionThemeAnimation))]
  [Guid(1301459377, 34315, 19449, 165, 157, 30, 177, 204, 190, 143, 224)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRepositionThemeAnimationStatics
  {
    DependencyProperty TargetNameProperty { get; }

    DependencyProperty FromHorizontalOffsetProperty { get; }

    DependencyProperty FromVerticalOffsetProperty { get; }
  }
}
