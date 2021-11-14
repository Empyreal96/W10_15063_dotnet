// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.FontWeights
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IFontWeightsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FontWeights : IFontWeights
  {
    public static extern FontWeight Black { [MethodImpl] get; }

    public static extern FontWeight Bold { [MethodImpl] get; }

    public static extern FontWeight ExtraBlack { [MethodImpl] get; }

    public static extern FontWeight ExtraBold { [MethodImpl] get; }

    public static extern FontWeight ExtraLight { [MethodImpl] get; }

    public static extern FontWeight Light { [MethodImpl] get; }

    public static extern FontWeight Medium { [MethodImpl] get; }

    public static extern FontWeight Normal { [MethodImpl] get; }

    public static extern FontWeight SemiBold { [MethodImpl] get; }

    public static extern FontWeight SemiLight { [MethodImpl] get; }

    public static extern FontWeight Thin { [MethodImpl] get; }
  }
}
