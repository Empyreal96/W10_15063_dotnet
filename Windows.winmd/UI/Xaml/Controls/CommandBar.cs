// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CommandBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (ICommandBarStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICommandBarStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (ICommandBarFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (ICommandBarStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "PrimaryCommands")]
  [Threading(ThreadingModel.Both)]
  public class CommandBar : AppBar, ICommandBar, ICommandBar2, ICommandBar3
  {
    [MethodImpl]
    public extern CommandBar();

    public extern IObservableVector<ICommandBarElement> PrimaryCommands { [MethodImpl] get; }

    public extern IObservableVector<ICommandBarElement> SecondaryCommands { [MethodImpl] get; }

    public extern Style CommandBarOverflowPresenterStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern CommandBarTemplateSettings CommandBarTemplateSettings { [MethodImpl] get; }

    public extern CommandBarDefaultLabelPosition DefaultLabelPosition { [MethodImpl] get; [MethodImpl] set; }

    public extern CommandBarOverflowButtonVisibility OverflowButtonVisibility { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsDynamicOverflowEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<CommandBar, DynamicOverflowItemsChangingEventArgs> DynamicOverflowItemsChanging;

    public static extern DependencyProperty DefaultLabelPositionProperty { [MethodImpl] get; }

    public static extern DependencyProperty OverflowButtonVisibilityProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsDynamicOverflowEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty CommandBarOverflowPresenterStyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty PrimaryCommandsProperty { [MethodImpl] get; }

    public static extern DependencyProperty SecondaryCommandsProperty { [MethodImpl] get; }
  }
}
