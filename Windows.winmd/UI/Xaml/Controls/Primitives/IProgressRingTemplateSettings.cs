// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IProgressRingTemplateSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(3115742700, 50979, 17126, 131, 233, 152, 38, 39, 43, 220, 14)]
  [ExclusiveTo(typeof (ProgressRingTemplateSettings))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProgressRingTemplateSettings
  {
    double EllipseDiameter { get; }

    Thickness EllipseOffset { get; }

    double MaxSideLength { get; }
  }
}
