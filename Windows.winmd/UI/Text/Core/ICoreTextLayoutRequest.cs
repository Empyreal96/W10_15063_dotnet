// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextLayoutRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [Guid(626370764, 20989, 20227, 152, 191, 172, 120, 23, 77, 104, 224)]
  [ExclusiveTo(typeof (CoreTextLayoutRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreTextLayoutRequest
  {
    CoreTextRange Range { get; }

    CoreTextLayoutBounds LayoutBounds { get; }

    bool IsCanceled { get; }

    Deferral GetDeferral();
  }
}
