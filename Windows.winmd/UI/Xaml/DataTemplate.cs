// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DataTemplate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Static(typeof (IDataTemplateStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IDataTemplateFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class DataTemplate : FrameworkTemplate, IDataTemplate
  {
    [MethodImpl]
    public extern DataTemplate();

    [MethodImpl]
    public extern DependencyObject LoadContent();

    public static extern DependencyProperty ExtensionInstanceProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern IDataTemplateExtension GetExtensionInstance(
      FrameworkElement element);

    [MethodImpl]
    public static extern void SetExtensionInstance(
      FrameworkElement element,
      IDataTemplateExtension value);
  }
}
