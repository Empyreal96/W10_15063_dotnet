// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileSavePicker2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FileSavePicker))]
  [Guid(247665570, 53835, 17562, 129, 151, 232, 145, 4, 253, 66, 204)]
  internal interface IFileSavePicker2 : IFileSavePicker
  {
    ValueSet ContinuationData { get; }

    [Deprecated("Instead, use PickSaveFileAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void PickSaveFileAndContinue();
  }
}
