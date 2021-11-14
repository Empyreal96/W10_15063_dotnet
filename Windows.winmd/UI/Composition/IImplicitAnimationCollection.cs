// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IImplicitAnimationCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(93889535, 2706, 19613, 164, 39, 178, 85, 25, 37, 13, 191)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ImplicitAnimationCollection))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IImplicitAnimationCollection : 
    IMap<string, ICompositionAnimationBase>,
    IIterable<IKeyValuePair<string, ICompositionAnimationBase>>
  {
  }
}
