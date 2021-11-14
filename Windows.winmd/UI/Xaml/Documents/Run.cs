// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.Run
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Documents
{
  [ContentProperty(Name = "Text")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IRunStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Run : Inline, IRun
  {
    [MethodImpl]
    public extern Run();

    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    public extern FlowDirection FlowDirection { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty FlowDirectionProperty { [MethodImpl] get; }
  }
}
