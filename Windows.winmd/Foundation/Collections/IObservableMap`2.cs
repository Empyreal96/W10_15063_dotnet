// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IObservableMap`2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(1709124597, 48953, 16821, 174, 188, 90, 157, 134, 94, 71, 43)]
  public interface IObservableMap<K, V> : IMap<K, V>
  {
    event MapChangedEventHandler<K, V> MapChanged;
  }
}
