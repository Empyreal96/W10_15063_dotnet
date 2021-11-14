// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapPropertySet
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BitmapPropertySet : 
    IMap<string, BitmapTypedValue>,
    IIterable<IKeyValuePair<string, BitmapTypedValue>>
  {
    [MethodImpl]
    public extern BitmapPropertySet();

    [MethodImpl]
    public extern BitmapTypedValue Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, BitmapTypedValue> GetView();

    [MethodImpl]
    public extern bool Insert(string key, BitmapTypedValue value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, BitmapTypedValue>> First();
  }
}
