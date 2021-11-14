// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.VisualUnorderedCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VisualUnorderedCollection : 
    CompositionObject,
    IVisualUnorderedCollection,
    IIterable<Visual>
  {
    public extern int Count { [MethodImpl] get; }

    [MethodImpl]
    public extern void Add(Visual newVisual);

    [MethodImpl]
    public extern void Remove(Visual visual);

    [MethodImpl]
    public extern void RemoveAll();

    [MethodImpl]
    public extern IIterator<Visual> First();
  }
}
