// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SymbolIcon
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISymbolIconStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (ISymbolIconFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SymbolIcon : IconElement, ISymbolIcon
  {
    [MethodImpl]
    public extern SymbolIcon(Symbol symbol);

    [MethodImpl]
    public extern SymbolIcon();

    public extern Symbol Symbol { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty SymbolProperty { [MethodImpl] get; }
  }
}
