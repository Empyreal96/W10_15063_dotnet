// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataPackagePropertySet
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DataPackagePropertySet : 
    IDataPackagePropertySet,
    IMap<string, object>,
    IIterable<IKeyValuePair<string, object>>,
    IDataPackagePropertySet2,
    IDataPackagePropertySet3
  {
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> FileTypes { [MethodImpl] get; }

    public extern string ApplicationName { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri ApplicationListingUri { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern object Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, object> GetView();

    [MethodImpl]
    public extern bool Insert(string key, object value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, object>> First();

    public extern Uri ContentSourceWebLink { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri ContentSourceApplicationLink { [MethodImpl] get; [MethodImpl] set; }

    public extern string PackageFamilyName { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference Square30x30Logo { [MethodImpl] get; [MethodImpl] set; }

    public extern Color LogoBackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    public extern string EnterpriseId { [MethodImpl] get; [MethodImpl] set; }
  }
}
