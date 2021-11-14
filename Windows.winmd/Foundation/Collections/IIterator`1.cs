// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IIterator`1
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(1786374243, 17152, 17818, 153, 102, 203, 182, 96, 150, 62, 225)]
  public interface IIterator<T>
  {
    T Current { [MethodImpl] get; }

    bool HasCurrent { [MethodImpl] get; }

    [MethodImpl]
    bool MoveNext();

    [MethodImpl]
    uint GetMany([LengthIs(0), Out] T[] items);
  }
}
