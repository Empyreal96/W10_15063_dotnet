// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataPackageView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.EnterpriseData;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.DataTransfer
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class DataPackageView : 
    IDataPackageView,
    IDataPackageView2,
    IDataPackageView3,
    IDataPackageView4
  {
    public extern DataPackagePropertySetView Properties { [MethodImpl] get; }

    public extern DataPackageOperation RequestedOperation { [MethodImpl] get; }

    [MethodImpl]
    public extern void ReportOperationCompleted(DataPackageOperation value);

    public extern IVectorView<string> AvailableFormats { [MethodImpl] get; }

    [MethodImpl]
    public extern bool Contains(string formatId);

    [RemoteAsync]
    [MethodImpl]
    [return: HasVariant]
    public extern IAsyncOperation<object> GetDataAsync(string formatId);

    [RemoteAsync]
    [Overload("GetTextAsync")]
    [MethodImpl]
    public extern IAsyncOperation<string> GetTextAsync();

    [Overload("GetCustomTextAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetTextAsync(string formatId);

    [RemoteAsync]
    [Deprecated("GetUriAsync may be altered or unavailable for releases after Windows 8.1. Instead, use GetWebLinkAsync or GetApplicationLinkAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<Uri> GetUriAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetHtmlFormatAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IMapView<string, RandomAccessStreamReference>> GetResourceMapAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetRtfAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<RandomAccessStreamReference> GetBitmapAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IStorageItem>> GetStorageItemsAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Uri> GetApplicationLinkAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Uri> GetWebLinkAsync();

    [Overload("RequestAccessAsync")]
    [MethodImpl]
    public extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync();

    [Overload("RequestAccessWithEnterpriseIdAsync")]
    [MethodImpl]
    public extern IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync(
      string enterpriseId);

    [MethodImpl]
    public extern ProtectionPolicyEvaluationResult UnlockAndAssumeEnterpriseIdentity();

    [MethodImpl]
    public extern void SetAcceptedFormatId(string formatId);
  }
}
