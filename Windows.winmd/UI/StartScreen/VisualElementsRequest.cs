// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.VisualElementsRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VisualElementsRequest : IVisualElementsRequest
  {
    public extern SecondaryTileVisualElements VisualElements { [MethodImpl] get; }

    public extern IVectorView<SecondaryTileVisualElements> AlternateVisualElements { [MethodImpl] get; }

    public extern DateTime Deadline { [MethodImpl] get; }

    [MethodImpl]
    public extern VisualElementsRequestDeferral GetDeferral();
  }
}
