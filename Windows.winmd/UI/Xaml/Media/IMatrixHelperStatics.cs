// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IMatrixHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MatrixHelper))]
  [Guid(3246786214, 14836, 19338, 132, 3, 40, 229, 229, 240, 51, 180)]
  internal interface IMatrixHelperStatics
  {
    Matrix Identity { get; }

    Matrix FromElements(
      double m11,
      double m12,
      double m21,
      double m22,
      double offsetX,
      double offsetY);

    bool GetIsIdentity(Matrix target);

    Point Transform(Matrix target, Point point);
  }
}
