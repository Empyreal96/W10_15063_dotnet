// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionAnimationGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (CompositionAnimationGroup))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1585236236, 52500, 19975, 138, 85, 199, 37, 39, 170, 189, 172)]
  internal interface ICompositionAnimationGroup : IIterable<CompositionAnimation>
  {
    int Count { get; }

    void Add(CompositionAnimation value);

    void Remove(CompositionAnimation value);

    void RemoveAll();
  }
}
