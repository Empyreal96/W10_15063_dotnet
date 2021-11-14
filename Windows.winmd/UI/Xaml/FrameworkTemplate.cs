// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FrameworkTemplate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml
{
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IFrameworkTemplateFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "Template")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class FrameworkTemplate : DependencyObject, IFrameworkTemplate
  {
    [MethodImpl]
    protected extern FrameworkTemplate();
  }
}
