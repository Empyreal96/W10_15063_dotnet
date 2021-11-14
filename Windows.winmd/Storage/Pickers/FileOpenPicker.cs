// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.FileOpenPicker
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
  [Static(typeof (IFileOpenPickerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class FileOpenPicker : 
    IFileOpenPicker,
    IFileOpenPickerWithOperationId,
    IFileOpenPicker2
  {
    [MethodImpl]
    public extern FileOpenPicker();

    public extern PickerViewMode ViewMode { [MethodImpl] get; [MethodImpl] set; }

    public extern string SettingsIdentifier { [MethodImpl] get; [MethodImpl] set; }

    public extern PickerLocationId SuggestedStartLocation { [MethodImpl] get; [MethodImpl] set; }

    public extern string CommitButtonText { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> FileTypeFilter { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<StorageFile> PickSingleFileAsync();

    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageFile>> PickMultipleFilesAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> PickSingleFileAsync(
      string pickerOperationId);

    public extern ValueSet ContinuationData { [Deprecated("Instead, use PickSingleFileAsync/PickMultipleFilesAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    [Deprecated("Instead, use PickSingleFileAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void PickSingleFileAndContinue();

    [Deprecated("Instead, use PickMultipleFilesAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void PickMultipleFilesAndContinue();

    [RemoteAsync]
    [Deprecated("Instead, use PickSingleFileAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> ResumePickSingleFileAsync();
  }
}
