// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.Block
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IBlockFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBlockStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class Block : TextElement, IBlock
  {
    [MethodImpl]
    protected extern Block();

    public extern TextAlignment TextAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern double LineHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern LineStackingStrategy LineStackingStrategy { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness Margin { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty TextAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty LineHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty LineStackingStrategyProperty { [MethodImpl] get; }

    public static extern DependencyProperty MarginProperty { [MethodImpl] get; }
  }
}
