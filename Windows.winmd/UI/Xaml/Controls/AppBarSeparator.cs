// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.AppBarSeparator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (IAppBarSeparatorStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAppBarSeparatorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IAppBarSeparatorFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class AppBarSeparator : Control, IAppBarSeparator, ICommandBarElement, ICommandBarElement2
  {
    [MethodImpl]
    public extern AppBarSeparator();

    public extern bool IsCompact { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsInOverflow { [MethodImpl] get; }

    public extern int DynamicOverflowOrder { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty IsInOverflowProperty { [MethodImpl] get; }

    public static extern DependencyProperty DynamicOverflowOrderProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsCompactProperty { [MethodImpl] get; }
  }
}
