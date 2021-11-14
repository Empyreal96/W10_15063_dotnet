// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2768915389, 33633, 18076, 144, 218, 233, 164, 12, 116, 116, 223)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Panel))]
  internal interface IPanel
  {
    UIElementCollection Children { get; }

    Brush Background { get; set; }

    bool IsItemsHost { get; }

    TransitionCollection ChildrenTransitions { get; set; }
  }
}
