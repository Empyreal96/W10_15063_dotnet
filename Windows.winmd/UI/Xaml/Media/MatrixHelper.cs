// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.MatrixHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMatrixHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class MatrixHelper : IMatrixHelper
  {
    public static extern Matrix Identity { [MethodImpl] get; }

    [MethodImpl]
    public static extern Matrix FromElements(
      double m11,
      double m12,
      double m21,
      double m22,
      double offsetX,
      double offsetY);

    [MethodImpl]
    public static extern bool GetIsIdentity(Matrix target);

    [MethodImpl]
    public static extern Point Transform(Matrix target, Point point);
  }
}
