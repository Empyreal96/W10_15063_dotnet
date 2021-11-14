// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IDataPackageView
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2072249457, 22784, 19845, 169, 11, 16, 203, 133, 254, 53, 82)]
  [ExclusiveTo(typeof (DataPackageView))]
  internal interface IDataPackageView
  {
    DataPackagePropertySetView Properties { get; }

    DataPackageOperation RequestedOperation { get; }

    void ReportOperationCompleted(DataPackageOperation value);

    IVectorView<string> AvailableFormats { get; }

    bool Contains(string formatId);

    [RemoteAsync]
    [return: HasVariant]
    IAsyncOperation<object> GetDataAsync(string formatId);

    [RemoteAsync]
    [Overload("GetTextAsync")]
    IAsyncOperation<string> GetTextAsync();

    [Overload("GetCustomTextAsync")]
    [RemoteAsync]
    IAsyncOperation<string> GetTextAsync(string formatId);

    [RemoteAsync]
    [Deprecated("GetUriAsync may be altered or unavailable for releases after Windows 8.1. Instead, use GetWebLinkAsync or GetApplicationLinkAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<Uri> GetUriAsync();

    [RemoteAsync]
    IAsyncOperation<string> GetHtmlFormatAsync();

    [RemoteAsync]
    IAsyncOperation<IMapView<string, RandomAccessStreamReference>> GetResourceMapAsync();

    [RemoteAsync]
    IAsyncOperation<string> GetRtfAsync();

    [RemoteAsync]
    IAsyncOperation<RandomAccessStreamReference> GetBitmapAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<IStorageItem>> GetStorageItemsAsync();
  }
}
