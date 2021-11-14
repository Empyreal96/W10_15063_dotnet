// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.CompositionInteractionSourceCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class CompositionInteractionSourceCollection : 
    CompositionObject,
    ICompositionInteractionSourceCollection,
    IIterable<ICompositionInteractionSource>
  {
    public extern int Count { [MethodImpl] get; }

    [MethodImpl]
    public extern void Add(ICompositionInteractionSource value);

    [MethodImpl]
    public extern void Remove(ICompositionInteractionSource value);

    [MethodImpl]
    public extern void RemoveAll();

    [MethodImpl]
    public extern IIterator<ICompositionInteractionSource> First();
  }
}
