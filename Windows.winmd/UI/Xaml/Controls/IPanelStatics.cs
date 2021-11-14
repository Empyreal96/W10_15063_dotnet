// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPanelStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Panel))]
  [Guid(4064111453, 33584, 18342, 160, 70, 37, 245, 9, 178, 82, 50)]
  [WebHostHidden]
  internal interface IPanelStatics
  {
    DependencyProperty BackgroundProperty { get; }

    DependencyProperty IsItemsHostProperty { get; }

    DependencyProperty ChildrenTransitionsProperty { get; }
  }
}
