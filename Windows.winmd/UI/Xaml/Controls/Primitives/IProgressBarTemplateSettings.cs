// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IProgressBarTemplateSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProgressBarTemplateSettings))]
  [Guid(1071835690, 58354, 19499, 148, 136, 145, 141, 119, 210, 187, 228)]
  [WebHostHidden]
  internal interface IProgressBarTemplateSettings
  {
    double EllipseDiameter { get; }

    double EllipseOffset { get; }

    double EllipseAnimationWellPosition { get; }

    double EllipseAnimationEndPosition { get; }

    double ContainerAnimationStartPosition { get; }

    double ContainerAnimationEndPosition { get; }

    double IndicatorLengthDelta { get; }
  }
}
