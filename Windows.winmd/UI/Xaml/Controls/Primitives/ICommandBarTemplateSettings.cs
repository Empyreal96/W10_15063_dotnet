// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ICommandBarTemplateSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1640560940, 1450, 16714, 162, 174, 72, 44, 90, 70, 192, 142)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CommandBarTemplateSettings))]
  internal interface ICommandBarTemplateSettings
  {
    double ContentHeight { get; }

    Rect OverflowContentClipRect { get; }

    double OverflowContentMinWidth { get; }

    double OverflowContentMaxHeight { get; }

    double OverflowContentHorizontalOffset { get; }

    double OverflowContentHeight { get; }

    double NegativeOverflowContentHeight { get; }
  }
}
