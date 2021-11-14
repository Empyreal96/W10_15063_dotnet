// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IColorAnimationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(1441461986, 34787, 20296, 149, 143, 133, 91, 47, 158, 169, 236)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ColorAnimation))]
  [WebHostHidden]
  internal interface IColorAnimationStatics
  {
    DependencyProperty FromProperty { get; }

    DependencyProperty ToProperty { get; }

    DependencyProperty ByProperty { get; }

    DependencyProperty EasingFunctionProperty { get; }

    DependencyProperty EnableDependentAnimationProperty { get; }
  }
}
