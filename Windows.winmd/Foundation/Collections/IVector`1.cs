// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IVector`1
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  [Guid(2436052969, 4513, 17221, 163, 162, 78, 127, 149, 110, 34, 45)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IVector<T> : IIterable<T>
  {
    [MethodImpl]
    T GetAt(uint index);

    uint Size { [MethodImpl] get; }

    [MethodImpl]
    IVectorView<T> GetView();

    [MethodImpl]
    bool IndexOf(T value, out uint index);

    [MethodImpl]
    void SetAt(uint index, T value);

    [MethodImpl]
    void InsertAt(uint index, T value);

    [MethodImpl]
    void RemoveAt(uint index);

    [MethodImpl]
    void Append(T value);

    [MethodImpl]
    void RemoveAtEnd();

    [MethodImpl]
    void Clear();

    [MethodImpl]
    uint GetMany(uint startIndex, [LengthIs(0), Out] T[] items);

    [MethodImpl]
    void ReplaceAll(T[] items);
  }
}
