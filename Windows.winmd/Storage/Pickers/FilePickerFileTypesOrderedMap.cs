// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.FilePickerFileTypesOrderedMap
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FilePickerFileTypesOrderedMap : 
    IMap<string, IVector<string>>,
    IIterable<IKeyValuePair<string, IVector<string>>>
  {
    [MethodImpl]
    public extern IVector<string> Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, IVector<string>> GetView();

    [MethodImpl]
    public extern bool Insert(string key, IVector<string> value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, IVector<string>>> First();
  }
}
