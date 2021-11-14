// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IMap`2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(1009329662, 34073, 17857, 170, 121, 25, 123, 103, 24, 193, 193)]
  public interface IMap<K, V> : IIterable<IKeyValuePair<K, V>>
  {
    [MethodImpl]
    V Lookup(K key);

    uint Size { [MethodImpl] get; }

    [MethodImpl]
    bool HasKey(K key);

    [MethodImpl]
    IMapView<K, V> GetView();

    [MethodImpl]
    bool Insert(K key, V value);

    [MethodImpl]
    void Remove(K key);

    [MethodImpl]
    void Clear();
  }
}
