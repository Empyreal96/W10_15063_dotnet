// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IFileOpenPickerActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Pickers.Provider;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1921151106, 21797, 19442, 188, 9, 31, 80, 149, 212, 150, 77)]
  public interface IFileOpenPickerActivatedEventArgs : IActivatedEventArgs
  {
    FileOpenPickerUI FileOpenPickerUI { get; }
  }
}
