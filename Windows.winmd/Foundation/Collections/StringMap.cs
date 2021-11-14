// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.StringMap
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.FoundationContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public sealed class StringMap : 
    IMap<string, string>,
    IIterable<IKeyValuePair<string, string>>,
    IObservableMap<string, string>
  {
    [MethodImpl]
    public extern StringMap();

    [MethodImpl]
    public extern string Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, string> GetView();

    [MethodImpl]
    public extern bool Insert(string key, string value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, string>> First();

    public extern event MapChangedEventHandler<string, string> MapChanged;
  }
}
