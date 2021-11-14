// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileOpenPickerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FileOpenPicker))]
  [Guid(1747015483, 12034, 18483, 150, 212, 171, 191, 173, 114, 182, 123)]
  internal interface IFileOpenPickerStatics
  {
    [Deprecated("Instead, use PickSingleFileAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<StorageFile> ResumePickSingleFileAsync();
  }
}
