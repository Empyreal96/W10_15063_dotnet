// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVisualCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(2339656965, 64830, 19096, 132, 168, 233, 73, 70, 140, 107, 203)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (VisualCollection))]
  [WebHostHidden]
  internal interface IVisualCollection : IIterable<Visual>
  {
    int Count { get; }

    void InsertAbove(Visual newChild, Visual sibling);

    void InsertAtBottom(Visual newChild);

    void InsertAtTop(Visual newChild);

    void InsertBelow(Visual newChild, Visual sibling);

    void Remove(Visual child);

    void RemoveAll();
  }
}
