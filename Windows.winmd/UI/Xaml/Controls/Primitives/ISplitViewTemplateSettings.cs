// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ISplitViewTemplateSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (SplitViewTemplateSettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3244996007, 18838, 17475, 177, 153, 107, 107, 137, 18, 78, 171)]
  [WebHostHidden]
  internal interface ISplitViewTemplateSettings
  {
    double OpenPaneLength { get; }

    double NegativeOpenPaneLength { get; }

    double OpenPaneLengthMinusCompactLength { get; }

    double NegativeOpenPaneLengthMinusCompactLength { get; }

    GridLength OpenPaneGridLength { get; }

    GridLength CompactPaneGridLength { get; }
  }
}
