// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.IPerspectiveTransform3DStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  [Guid(2389664768, 25100, 18631, 132, 77, 63, 9, 132, 218, 91, 23)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (PerspectiveTransform3D))]
  internal interface IPerspectiveTransform3DStatics
  {
    DependencyProperty DepthProperty { get; }

    DependencyProperty OffsetXProperty { get; }

    DependencyProperty OffsetYProperty { get; }
  }
}
