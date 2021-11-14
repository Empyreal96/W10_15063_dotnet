// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFolderPicker2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FolderPicker))]
  [Guid(2394143383, 56453, 17942, 190, 148, 150, 96, 136, 31, 47, 93)]
  internal interface IFolderPicker2 : IFolderPicker
  {
    ValueSet ContinuationData { get; }

    [Deprecated("Instead, use PickSingleFolderAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void PickFolderAndContinue();
  }
}
