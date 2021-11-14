// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileOpenPicker2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [Guid(2364239058, 46150, 18167, 178, 101, 144, 248, 229, 90, 214, 80)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FileOpenPicker))]
  internal interface IFileOpenPicker2 : IFileOpenPicker
  {
    ValueSet ContinuationData { [Deprecated("Instead, use PickSingleFileAsync/PickMultipleFilesAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("Instead, use PickSingleFileAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void PickSingleFileAndContinue();

    [Deprecated("Instead, use PickMultipleFilesAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void PickMultipleFilesAndContinue();
  }
}
