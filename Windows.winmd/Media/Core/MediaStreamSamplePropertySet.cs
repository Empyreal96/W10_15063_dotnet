// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSamplePropertySet
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [HasVariant]
  public sealed class MediaStreamSamplePropertySet : 
    IMap<Guid, object>,
    IIterable<IKeyValuePair<Guid, object>>
  {
    [MethodImpl]
    public extern object Lookup(Guid key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(Guid key);

    [MethodImpl]
    public extern IMapView<Guid, object> GetView();

    [MethodImpl]
    public extern bool Insert(Guid key, object value);

    [MethodImpl]
    public extern void Remove(Guid key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<Guid, object>> First();
  }
}
