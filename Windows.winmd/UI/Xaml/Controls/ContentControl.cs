// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContentControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [global::Windows.UI.Xaml.Markup.ContentProperty(Name = "Content")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IContentControlFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IContentControlStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class ContentControl : Control, IContentControl, IContentControlOverrides, IContentControl2
  {
    [MethodImpl]
    public extern ContentControl();

    public extern object Content { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate ContentTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplateSelector ContentTemplateSelector { [MethodImpl] get; [MethodImpl] set; }

    public extern TransitionCollection ContentTransitions { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern void IContentControlOverrides.OnContentChanged(
      object oldContent,
      object newContent);

    [MethodImpl]
    extern void IContentControlOverrides.OnContentTemplateChanged(
      DataTemplate oldContentTemplate,
      DataTemplate newContentTemplate);

    [MethodImpl]
    extern void IContentControlOverrides.OnContentTemplateSelectorChanged(
      DataTemplateSelector oldContentTemplateSelector,
      DataTemplateSelector newContentTemplateSelector);

    public extern UIElement ContentTemplateRoot { [MethodImpl] get; }

    public static extern DependencyProperty ContentProperty { [MethodImpl] get; }

    public static extern DependencyProperty ContentTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty ContentTemplateSelectorProperty { [MethodImpl] get; }

    public static extern DependencyProperty ContentTransitionsProperty { [MethodImpl] get; }
  }
}
