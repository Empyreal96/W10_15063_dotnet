// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.IFileOpenPickerUI
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FileOpenPickerUI))]
  [Guid(3718535696, 63956, 16580, 138, 245, 197, 182, 181, 166, 29, 29)]
  internal interface IFileOpenPickerUI
  {
    AddFileResult AddFile(string id, IStorageFile file);

    void RemoveFile(string id);

    bool ContainsFile(string id);

    bool CanAddFile(IStorageFile file);

    IVectorView<string> AllowedFileTypes { get; }

    FileSelectionMode SelectionMode { get; }

    string SettingsIdentifier { get; }

    string Title { get; set; }

    event TypedEventHandler<FileOpenPickerUI, FileRemovedEventArgs> FileRemoved;

    event TypedEventHandler<FileOpenPickerUI, PickerClosingEventArgs> Closing;
  }
}
