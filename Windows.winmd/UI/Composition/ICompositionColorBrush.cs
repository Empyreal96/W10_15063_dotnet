// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionColorBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionColorBrush))]
  [Guid(723930206, 48949, 18481, 134, 66, 207, 112, 194, 15, 255, 47)]
  internal interface ICompositionColorBrush
  {
    Color Color { get; set; }
  }
}
