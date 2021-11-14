// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGridStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Grid))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1694379679, 63825, 17078, 169, 206, 187, 23, 154, 241, 21, 149)]
  internal interface IGridStatics
  {
    DependencyProperty RowProperty { get; }

    int GetRow(FrameworkElement element);

    void SetRow(FrameworkElement element, int value);

    DependencyProperty ColumnProperty { get; }

    int GetColumn(FrameworkElement element);

    void SetColumn(FrameworkElement element, int value);

    DependencyProperty RowSpanProperty { get; }

    int GetRowSpan(FrameworkElement element);

    void SetRowSpan(FrameworkElement element, int value);

    DependencyProperty ColumnSpanProperty { get; }

    int GetColumnSpan(FrameworkElement element);

    void SetColumnSpan(FrameworkElement element, int value);
  }
}
