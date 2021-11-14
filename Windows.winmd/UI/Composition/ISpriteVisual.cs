// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ISpriteVisual
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(148919681, 6865, 20375, 151, 87, 64, 45, 118, 228, 35, 59)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpriteVisual))]
  internal interface ISpriteVisual
  {
    CompositionBrush Brush { get; set; }
  }
}
