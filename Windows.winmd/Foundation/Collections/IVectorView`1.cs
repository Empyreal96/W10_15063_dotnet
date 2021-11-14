// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IVectorView`1
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  [Guid(3152149068, 45283, 17795, 186, 239, 31, 27, 46, 72, 62, 86)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IVectorView<T> : IIterable<T>
  {
    [MethodImpl]
    T GetAt(uint index);

    uint Size { [MethodImpl] get; }

    [MethodImpl]
    bool IndexOf(T value, out uint index);

    [MethodImpl]
    uint GetMany(uint startIndex, [LengthIs(0), Out] T[] items);
  }
}
