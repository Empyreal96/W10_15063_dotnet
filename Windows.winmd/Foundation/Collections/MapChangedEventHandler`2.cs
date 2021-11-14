// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.MapChangedEventHandler`2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  [Guid(395646963, 38126, 16888, 189, 220, 118, 138, 137, 85, 68, 243)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public delegate void MapChangedEventHandler<K, V>(
    IObservableMap<K, V> sender,
    IMapChangedEventArgs<K> @event);
}
