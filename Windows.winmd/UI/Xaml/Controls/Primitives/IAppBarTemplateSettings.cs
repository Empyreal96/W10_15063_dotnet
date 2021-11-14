// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IAppBarTemplateSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (AppBarTemplateSettings))]
  [Guid(3166873699, 60213, 16956, 131, 137, 215, 130, 123, 227, 191, 103)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppBarTemplateSettings
  {
    Rect ClipRect { get; }

    double CompactVerticalDelta { get; }

    Thickness CompactRootMargin { get; }

    double MinimalVerticalDelta { get; }

    Thickness MinimalRootMargin { get; }

    double HiddenVerticalDelta { get; }

    Thickness HiddenRootMargin { get; }
  }
}
