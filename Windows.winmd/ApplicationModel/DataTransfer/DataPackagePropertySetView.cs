// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataPackagePropertySetView
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
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DataPackagePropertySetView : 
    IDataPackagePropertySetView,
    IMapView<string, object>,
    IIterable<IKeyValuePair<string, object>>,
    IDataPackagePropertySetView2,
    IDataPackagePropertySetView3
  {
    public extern string Title { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }

    public extern RandomAccessStreamReference Thumbnail { [MethodImpl] get; }

    public extern IVectorView<string> FileTypes { [MethodImpl] get; }

    public extern string ApplicationName { [MethodImpl] get; }

    public extern Uri ApplicationListingUri { [MethodImpl] get; }

    [MethodImpl]
    public extern object Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern void Split(
      out IMapView<string, object> first,
      out IMapView<string, object> second);

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, object>> First();

    public extern string PackageFamilyName { [MethodImpl] get; }

    public extern Uri ContentSourceWebLink { [MethodImpl] get; }

    public extern Uri ContentSourceApplicationLink { [MethodImpl] get; }

    public extern IRandomAccessStreamReference Square30x30Logo { [MethodImpl] get; }

    public extern Color LogoBackgroundColor { [MethodImpl] get; }

    public extern string EnterpriseId { [MethodImpl] get; }
  }
}
