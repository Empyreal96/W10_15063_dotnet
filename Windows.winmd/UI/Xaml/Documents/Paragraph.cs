// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.Paragraph
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Documents
{
  [Static(typeof (IParagraphStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ContentProperty(Name = "Inlines")]
  public sealed class Paragraph : Block, IParagraph
  {
    [MethodImpl]
    public extern Paragraph();

    public extern InlineCollection Inlines { [MethodImpl] get; }

    public extern double TextIndent { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty TextIndentProperty { [MethodImpl] get; }
  }
}
