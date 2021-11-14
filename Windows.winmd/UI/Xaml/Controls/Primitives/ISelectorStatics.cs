// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ISelectorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Selector))]
  [Guid(321915654, 48400, 19977, 191, 247, 113, 239, 184, 187, 180, 43)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISelectorStatics
  {
    DependencyProperty SelectedIndexProperty { get; }

    DependencyProperty SelectedItemProperty { get; }

    DependencyProperty SelectedValueProperty { get; }

    DependencyProperty SelectedValuePathProperty { get; }

    DependencyProperty IsSynchronizedWithCurrentItemProperty { get; }

    bool GetIsSelectionActive(DependencyObject element);
  }
}
