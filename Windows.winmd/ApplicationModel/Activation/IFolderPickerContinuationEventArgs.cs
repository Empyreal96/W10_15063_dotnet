// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFolderPickerContinuationEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1367876454, 40779, 18831, 190, 176, 66, 104, 79, 110, 28, 41)]
  public interface IFolderPickerContinuationEventArgs : 
    IContinuationActivatedEventArgs,
    IActivatedEventArgs
  {
    StorageFolder Folder { get; }
  }
}
