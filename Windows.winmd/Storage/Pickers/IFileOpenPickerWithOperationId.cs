// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.IFileOpenPickerWithOperationId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FileOpenPicker))]
  [Guid(1062712681, 9506, 19621, 170, 115, 161, 85, 9, 241, 252, 191)]
  internal interface IFileOpenPickerWithOperationId
  {
    [RemoteAsync]
    IAsyncOperation<StorageFile> PickSingleFileAsync(
      string pickerOperationId);
  }
}
