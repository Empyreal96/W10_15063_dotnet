// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.TransitionCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TransitionCollection : IVector<Transition>, IIterable<Transition>
  {
    [MethodImpl]
    public extern TransitionCollection();

    [MethodImpl]
    public extern Transition GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<Transition> GetView();

    [MethodImpl]
    public extern bool IndexOf(Transition value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, Transition value);

    [MethodImpl]
    public extern void InsertAt(uint index, Transition value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(Transition value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] Transition[] items);

    [MethodImpl]
    public extern void ReplaceAll(Transition[] items);

    [MethodImpl]
    public extern IIterator<Transition> First();
  }
}
