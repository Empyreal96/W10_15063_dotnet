// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SemanticZoomLocation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SemanticZoomLocation : ISemanticZoomLocation
  {
    [MethodImpl]
    public extern SemanticZoomLocation();

    public extern object Item { [MethodImpl] get; [MethodImpl] set; }

    public extern Rect Bounds { [MethodImpl] get; [MethodImpl] set; }
  }
}
