// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ISpriteVisual2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (SpriteVisual))]
  [Guid(1485608548, 39290, 18512, 145, 254, 83, 203, 88, 248, 28, 233)]
  internal interface ISpriteVisual2
  {
    CompositionShadow Shadow { get; set; }
  }
}
