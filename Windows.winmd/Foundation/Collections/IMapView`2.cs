// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IMapView`2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  [Guid(3833646656, 41784, 19162, 173, 207, 39, 34, 114, 228, 140, 185)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IMapView<K, V> : IIterable<IKeyValuePair<K, V>>
  {
    [MethodImpl]
    V Lookup(K key);

    uint Size { [MethodImpl] get; }

    [MethodImpl]
    bool HasKey(K key);

    [MethodImpl]
    void Split(out IMapView<K, V> first, out IMapView<K, V> second);
  }
}
