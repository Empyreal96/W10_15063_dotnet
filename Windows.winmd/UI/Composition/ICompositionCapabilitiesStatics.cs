// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionCapabilitiesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(4156008558, 25622, 18917, 141, 223, 175, 233, 73, 226, 5, 98)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (CompositionCapabilities))]
  internal interface ICompositionCapabilitiesStatics
  {
    CompositionCapabilities GetForCurrentView();
  }
}
