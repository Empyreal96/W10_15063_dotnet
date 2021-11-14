// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFolderPicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [Guid(139425689, 62459, 16394, 153, 177, 123, 74, 119, 47, 214, 13)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FolderPicker))]
  internal interface IFolderPicker
  {
    PickerViewMode ViewMode { get; set; }

    string SettingsIdentifier { get; set; }

    PickerLocationId SuggestedStartLocation { get; set; }

    string CommitButtonText { get; set; }

    IVector<string> FileTypeFilter { get; }

    IAsyncOperation<StorageFolder> PickSingleFolderAsync();
  }
}
