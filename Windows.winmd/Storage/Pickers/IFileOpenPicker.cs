// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileOpenPicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [ExclusiveTo(typeof (FileOpenPicker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(749217674, 4805, 19551, 137, 119, 148, 84, 119, 147, 194, 65)]
  internal interface IFileOpenPicker
  {
    PickerViewMode ViewMode { get; set; }

    string SettingsIdentifier { get; set; }

    PickerLocationId SuggestedStartLocation { get; set; }

    string CommitButtonText { get; set; }

    IVector<string> FileTypeFilter { get; }

    IAsyncOperation<StorageFile> PickSingleFileAsync();

    IAsyncOperation<IVectorView<StorageFile>> PickMultipleFilesAsync();
  }
}
