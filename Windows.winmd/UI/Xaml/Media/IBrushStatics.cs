// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IBrushStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Brush))]
  [Guid(3876335874, 549, 18421, 178, 46, 4, 103, 97, 159, 106, 34)]
  internal interface IBrushStatics
  {
    DependencyProperty OpacityProperty { get; }

    DependencyProperty TransformProperty { get; }

    DependencyProperty RelativeTransformProperty { get; }
  }
}
