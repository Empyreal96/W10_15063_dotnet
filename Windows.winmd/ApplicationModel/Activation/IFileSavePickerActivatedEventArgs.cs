// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFileSavePickerActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Pickers.Provider;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2176949489, 29926, 17287, 130, 235, 187, 143, 214, 75, 67, 70)]
  public interface IFileSavePickerActivatedEventArgs : IActivatedEventArgs
  {
    FileSavePickerUI FileSavePickerUI { get; }
  }
}
