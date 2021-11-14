// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.BlockCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BlockCollection : IVector<Block>, IIterable<Block>
  {
    [MethodImpl]
    public extern Block GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<Block> GetView();

    [MethodImpl]
    public extern bool IndexOf(Block value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, Block value);

    [MethodImpl]
    public extern void InsertAt(uint index, Block value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(Block value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] Block[] items);

    [MethodImpl]
    public extern void ReplaceAll(Block[] items);

    [MethodImpl]
    public extern IIterator<Block> First();
  }
}
