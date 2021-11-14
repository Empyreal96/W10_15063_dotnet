// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionLight
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (CompositionLight))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1101453250, 11869, 19393, 176, 158, 143, 10, 3, 227, 216, 211)]
  [WebHostHidden]
  internal interface ICompositionLight
  {
    VisualUnorderedCollection Targets { get; }
  }
}
