// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RowDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IRowDefinitionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class RowDefinition : DependencyObject, IRowDefinition
  {
    [MethodImpl]
    public extern RowDefinition();

    public extern GridLength Height { [MethodImpl] get; [MethodImpl] set; }

    public extern double MaxHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern double MinHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern double ActualHeight { [MethodImpl] get; }

    public static extern DependencyProperty HeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty MinHeightProperty { [MethodImpl] get; }
  }
}
