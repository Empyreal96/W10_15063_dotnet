// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ManipulationPivot
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IManipulationPivotFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class ManipulationPivot : IManipulationPivot
  {
    [MethodImpl]
    public extern ManipulationPivot(Point center, double radius);

    [MethodImpl]
    public extern ManipulationPivot();

    public extern Point Center { [MethodImpl] get; [MethodImpl] set; }

    public extern double Radius { [MethodImpl] get; [MethodImpl] set; }
  }
}
