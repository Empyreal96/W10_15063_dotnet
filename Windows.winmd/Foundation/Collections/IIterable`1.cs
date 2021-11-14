// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IIterable`1
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  [Guid(4205151722, 25108, 16919, 175, 218, 127, 70, 222, 88, 105, 179)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IIterable<T>
  {
    [MethodImpl]
    IIterator<T> First();
  }
}
