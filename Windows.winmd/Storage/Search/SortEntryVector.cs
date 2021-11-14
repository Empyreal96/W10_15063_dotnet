// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.SortEntryVector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SortEntryVector : IVector<SortEntry>, IIterable<SortEntry>
  {
    [MethodImpl]
    public extern SortEntry GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<SortEntry> GetView();

    [MethodImpl]
    public extern bool IndexOf(SortEntry value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, SortEntry value);

    [MethodImpl]
    public extern void InsertAt(uint index, SortEntry value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(SortEntry value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] SortEntry[] items);

    [MethodImpl]
    public extern void ReplaceAll(SortEntry[] items);

    [MethodImpl]
    public extern IIterator<SortEntry> First();
  }
}
