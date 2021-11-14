// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataPackage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.DataTransfer
{
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DataPackage : IDataPackage, IDataPackage2, IDataPackage3
  {
    [MethodImpl]
    public extern DataPackage();

    [MethodImpl]
    public extern DataPackageView GetView();

    public extern DataPackagePropertySet Properties { [MethodImpl] get; }

    public extern DataPackageOperation RequestedOperation { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<DataPackage, OperationCompletedEventArgs> OperationCompleted;

    public extern event TypedEventHandler<DataPackage, object> Destroyed;

    [MethodImpl]
    public extern void SetData(string formatId, [HasVariant] object value);

    [MethodImpl]
    public extern void SetDataProvider(string formatId, DataProviderHandler delayRenderer);

    [MethodImpl]
    public extern void SetText(string value);

    [Deprecated("SetUri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD). Instead, use SetWebLink or SetApplicationLink.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void SetUri(Uri value);

    [MethodImpl]
    public extern void SetHtmlFormat(string value);

    public extern IMap<string, RandomAccessStreamReference> ResourceMap { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetRtf(string value);

    [MethodImpl]
    public extern void SetBitmap(RandomAccessStreamReference value);

    [Overload("SetStorageItemsReadOnly")]
    [MethodImpl]
    public extern void SetStorageItems(IIterable<IStorageItem> value);

    [Overload("SetStorageItems")]
    [MethodImpl]
    public extern void SetStorageItems(IIterable<IStorageItem> value, bool readOnly);

    [MethodImpl]
    public extern void SetApplicationLink(Uri value);

    [MethodImpl]
    public extern void SetWebLink(Uri value);

    public extern event TypedEventHandler<DataPackage, ShareCompletedEventArgs> ShareCompleted;
  }
}
