// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.TransformCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TransformCollection : IVector<Transform>, IIterable<Transform>
  {
    [MethodImpl]
    public extern TransformCollection();

    [MethodImpl]
    public extern Transform GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<Transform> GetView();

    [MethodImpl]
    public extern bool IndexOf(Transform value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, Transform value);

    [MethodImpl]
    public extern void InsertAt(uint index, Transform value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(Transform value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] Transform[] items);

    [MethodImpl]
    public extern void ReplaceAll(Transform[] items);

    [MethodImpl]
    public extern IIterator<Transform> First();
  }
}
