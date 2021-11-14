// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGeometryStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Geometry))]
  [Guid(2054204044, 2822, 18015, 182, 55, 154, 71, 229, 167, 1, 17)]
  [WebHostHidden]
  internal interface IGeometryStatics
  {
    Geometry Empty { get; }

    double StandardFlatteningTolerance { get; }

    DependencyProperty TransformProperty { [ConditionallyIndependentlyAnimatable] get; }
  }
}
