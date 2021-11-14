// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IVisualElementsRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [Guid(3241685818, 37640, 16498, 136, 204, 208, 104, 219, 52, 124, 104)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VisualElementsRequest))]
  internal interface IVisualElementsRequest
  {
    SecondaryTileVisualElements VisualElements { get; }

    IVectorView<SecondaryTileVisualElements> AlternateVisualElements { get; }

    DateTime Deadline { get; }

    VisualElementsRequestDeferral GetDeferral();
  }
}
