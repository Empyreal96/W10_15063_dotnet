// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.FileSavePickerUI
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
  public sealed class FileSavePickerUI : IFileSavePickerUI
  {
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern IVectorView<string> AllowedFileTypes { [MethodImpl] get; }

    public extern string SettingsIdentifier { [MethodImpl] get; }

    public extern string FileName { [MethodImpl] get; }

    [MethodImpl]
    public extern SetFileNameResult TrySetFileName(string value);

    public extern event TypedEventHandler<FileSavePickerUI, object> FileNameChanged;

    public extern event TypedEventHandler<FileSavePickerUI, TargetFileRequestedEventArgs> TargetFileRequested;
  }
}
