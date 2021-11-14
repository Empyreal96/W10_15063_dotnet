// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ILoopingSelector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (LoopingSelector))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1285176836, 18471, 18905, 136, 6, 9, 57, 87, 176, 253, 33)]
  internal interface ILoopingSelector
  {
    bool ShouldLoop { get; set; }

    IVector<object> Items { get; set; }

    int SelectedIndex { get; set; }

    object SelectedItem { get; set; }

    int ItemWidth { get; set; }

    int ItemHeight { get; set; }

    DataTemplate ItemTemplate { get; set; }

    event SelectionChangedEventHandler SelectionChanged;
  }
}
