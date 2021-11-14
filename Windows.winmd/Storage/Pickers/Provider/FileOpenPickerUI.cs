// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.FileOpenPickerUI
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FileOpenPickerUI : IFileOpenPickerUI
  {
    [MethodImpl]
    public extern AddFileResult AddFile(string id, IStorageFile file);

    [MethodImpl]
    public extern void RemoveFile(string id);

    [MethodImpl]
    public extern bool ContainsFile(string id);

    [MethodImpl]
    public extern bool CanAddFile(IStorageFile file);

    public extern IVectorView<string> AllowedFileTypes { [MethodImpl] get; }

    public extern FileSelectionMode SelectionMode { [MethodImpl] get; }

    public extern string SettingsIdentifier { [MethodImpl] get; }

    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<FileOpenPickerUI, FileRemovedEventArgs> FileRemoved;

    public extern event TypedEventHandler<FileOpenPickerUI, PickerClosingEventArgs> Closing;
  }
}
