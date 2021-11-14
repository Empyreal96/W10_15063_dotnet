// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.VisualCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public sealed class VisualCollection : CompositionObject, IVisualCollection, IIterable<Visual>
  {
    public extern int Count { [MethodImpl] get; }

    [MethodImpl]
    public extern void InsertAbove(Visual newChild, Visual sibling);

    [MethodImpl]
    public extern void InsertAtBottom(Visual newChild);

    [MethodImpl]
    public extern void InsertAtTop(Visual newChild);

    [MethodImpl]
    public extern void InsertBelow(Visual newChild, Visual sibling);

    [MethodImpl]
    public extern void Remove(Visual child);

    [MethodImpl]
    public extern void RemoveAll();

    [MethodImpl]
    public extern IIterator<Visual> First();
  }
}
