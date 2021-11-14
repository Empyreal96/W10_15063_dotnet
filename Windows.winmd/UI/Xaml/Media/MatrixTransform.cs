// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.MatrixTransform
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMatrixTransformStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class MatrixTransform : Transform, IMatrixTransform
  {
    [MethodImpl]
    public extern MatrixTransform();

    public extern Matrix Matrix { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty MatrixProperty { [MethodImpl] get; }
  }
}
