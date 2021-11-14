// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.Inline
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IInlineFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  public class Inline : TextElement, IInline
  {
    [MethodImpl]
    protected extern Inline();
  }
}
