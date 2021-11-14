// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.HubSection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  [Composable(typeof (IHubSectionFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContentProperty(Name = "ContentTemplate")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IHubSectionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class HubSection : Control, IHubSection
  {
    [MethodImpl]
    public extern HubSection();

    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate ContentTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsHeaderInteractive { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty ContentTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsHeaderInteractiveProperty { [MethodImpl] get; }
  }
}
