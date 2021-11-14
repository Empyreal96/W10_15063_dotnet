// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ImplicitAnimationCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class ImplicitAnimationCollection : 
    CompositionObject,
    IImplicitAnimationCollection,
    IIterable<IKeyValuePair<string, ICompositionAnimationBase>>,
    IMap<string, ICompositionAnimationBase>
  {
    [MethodImpl]
    public extern ICompositionAnimationBase Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, ICompositionAnimationBase> GetView();

    [MethodImpl]
    public extern bool Insert(string key, ICompositionAnimationBase value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, ICompositionAnimationBase>> First();
  }
}
