// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.ICompositionInteractionSourceCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [Guid(457608779, 42431, 18392, 165, 71, 56, 148, 21, 90, 21, 140)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CompositionInteractionSourceCollection))]
  internal interface ICompositionInteractionSourceCollection : 
    IIterable<ICompositionInteractionSource>
  {
    int Count { get; }

    void Add(ICompositionInteractionSource value);

    void Remove(ICompositionInteractionSource value);

    void RemoveAll();
  }
}
