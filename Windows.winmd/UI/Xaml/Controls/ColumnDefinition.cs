// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ColumnDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (IColumnDefinitionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ColumnDefinition : DependencyObject, IColumnDefinition
  {
    [MethodImpl]
    public extern ColumnDefinition();

    public extern GridLength Width { [MethodImpl] get; [MethodImpl] set; }

    public extern double MaxWidth { [MethodImpl] get; [MethodImpl] set; }

    public extern double MinWidth { [MethodImpl] get; [MethodImpl] set; }

    public extern double ActualWidth { [MethodImpl] get; }

    public static extern DependencyProperty WidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty MinWidthProperty { [MethodImpl] get; }
  }
}
