// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextCompositionCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ExclusiveTo(typeof (CoreTextCompositionCompletedEventArgs))]
  [Guid(523561910, 47007, 16673, 165, 231, 253, 169, 184, 97, 110, 48)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreTextCompositionCompletedEventArgs
  {
    bool IsCanceled { get; }

    IVectorView<CoreTextCompositionSegment> CompositionSegments { get; }

    Deferral GetDeferral();
  }
}
