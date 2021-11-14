// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileSavePicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [Guid(847708107, 24959, 19653, 175, 106, 179, 253, 242, 154, 209, 69)]
  [ExclusiveTo(typeof (FileSavePicker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFileSavePicker
  {
    string SettingsIdentifier { get; set; }

    PickerLocationId SuggestedStartLocation { get; set; }

    string CommitButtonText { get; set; }

    IMap<string, IVector<string>> FileTypeChoices { get; }

    string DefaultFileExtension { get; set; }

    StorageFile SuggestedSaveFile { get; set; }

    string SuggestedFileName { get; set; }

    IAsyncOperation<StorageFile> PickSaveFileAsync();
  }
}
