// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ResourceDictionary
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IResourceDictionaryFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class ResourceDictionary : 
    DependencyObject,
    IResourceDictionary,
    IMap<object, object>,
    IIterable<IKeyValuePair<object, object>>
  {
    [MethodImpl]
    public extern ResourceDictionary();

    public extern Uri Source { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<ResourceDictionary> MergedDictionaries { [MethodImpl] get; }

    public extern IMap<object, object> ThemeDictionaries { [MethodImpl] get; }

    [MethodImpl]
    public extern object Lookup(object key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(object key);

    [MethodImpl]
    public extern IMapView<object, object> GetView();

    [MethodImpl]
    public extern bool Insert(object key, object value);

    [MethodImpl]
    public extern void Remove(object key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<object, object>> First();
  }
}
