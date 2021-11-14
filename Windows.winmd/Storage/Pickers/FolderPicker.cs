// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.FolderPicker
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
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class FolderPicker : IFolderPicker, IFolderPicker2
  {
    [MethodImpl]
    public extern FolderPicker();

    public extern PickerViewMode ViewMode { [MethodImpl] get; [MethodImpl] set; }

    public extern string SettingsIdentifier { [MethodImpl] get; [MethodImpl] set; }

    public extern PickerLocationId SuggestedStartLocation { [MethodImpl] get; [MethodImpl] set; }

    public extern string CommitButtonText { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> FileTypeFilter { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> PickSingleFolderAsync();

    public extern ValueSet ContinuationData { [MethodImpl] get; }

    [Deprecated("Instead, use PickSingleFolderAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void PickFolderAndContinue();
  }
}
