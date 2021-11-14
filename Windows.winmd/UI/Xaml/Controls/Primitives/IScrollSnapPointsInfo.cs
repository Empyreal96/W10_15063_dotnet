// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(459084598, 58907, 19793, 190, 65, 253, 141, 220, 85, 197, 140)]
  [WebHostHidden]
  public interface IScrollSnapPointsInfo
  {
    bool AreHorizontalSnapPointsRegular { get; }

    bool AreVerticalSnapPointsRegular { get; }

    event EventHandler<object> HorizontalSnapPointsChanged;

    event EventHandler<object> VerticalSnapPointsChanged;

    IVectorView<float> GetIrregularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment);

    float GetRegularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment,
      out float offset);
  }
}
