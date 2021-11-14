// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(1642853831, 61418, 17222, 149, 84, 152, 29, 126, 25, 143, 254)]
  [ExclusiveTo(typeof (DataPackage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataPackage
  {
    DataPackageView GetView();

    DataPackagePropertySet Properties { get; }

    DataPackageOperation RequestedOperation { get; set; }

    event TypedEventHandler<DataPackage, OperationCompletedEventArgs> OperationCompleted;

    event TypedEventHandler<DataPackage, object> Destroyed;

    void SetData(string formatId, [HasVariant] object value);

    void SetDataProvider(string formatId, DataProviderHandler delayRenderer);

    void SetText(string value);

    [Deprecated("SetUri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD). Instead, use SetWebLink or SetApplicationLink.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void SetUri(Uri value);

    void SetHtmlFormat(string value);

    IMap<string, RandomAccessStreamReference> ResourceMap { get; }

    void SetRtf(string value);

    void SetBitmap(RandomAccessStreamReference value);

    [Overload("SetStorageItemsReadOnly")]
    void SetStorageItems(IIterable<IStorageItem> value);

    [Overload("SetStorageItems")]
    void SetStorageItems(IIterable<IStorageItem> value, bool readOnly);
  }
}
