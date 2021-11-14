// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.FileSavePicker
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
  [Muse(Version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class FileSavePicker : IFileSavePicker, IFileSavePicker2, IFileSavePicker3
  {
    [MethodImpl]
    public extern FileSavePicker();

    public extern string SettingsIdentifier { [MethodImpl] get; [MethodImpl] set; }

    public extern PickerLocationId SuggestedStartLocation { [MethodImpl] get; [MethodImpl] set; }

    public extern string CommitButtonText { [MethodImpl] get; [MethodImpl] set; }

    public extern IMap<string, IVector<string>> FileTypeChoices { [MethodImpl] get; }

    public extern string DefaultFileExtension { [MethodImpl] get; [MethodImpl] set; }

    public extern StorageFile SuggestedSaveFile { [MethodImpl] get; [MethodImpl] set; }

    public extern string SuggestedFileName { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IAsyncOperation<StorageFile> PickSaveFileAsync();

    public extern ValueSet ContinuationData { [MethodImpl] get; }

    [Deprecated("Instead, use PickSaveFileAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void PickSaveFileAndContinue();

    public extern string EnterpriseId { [MethodImpl] get; [MethodImpl] set; }
  }
}
