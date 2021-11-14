// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.IFileSavePickerUI
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [ExclusiveTo(typeof (FileSavePickerUI))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2522268135, 15958, 17356, 138, 57, 51, 199, 61, 157, 84, 43)]
  internal interface IFileSavePickerUI
  {
    string Title { get; set; }

    IVectorView<string> AllowedFileTypes { get; }

    string SettingsIdentifier { get; }

    string FileName { get; }

    SetFileNameResult TrySetFileName(string value);

    event TypedEventHandler<FileSavePickerUI, object> FileNameChanged;

    event TypedEventHandler<FileSavePickerUI, TargetFileRequestedEventArgs> TargetFileRequested;
  }
}
