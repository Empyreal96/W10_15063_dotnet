// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IPickerReturnedActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(906883001, 43475, 18820, 164, 237, 158, 199, 52, 96, 73, 33)]
  public interface IPickerReturnedActivatedEventArgs : IActivatedEventArgs
  {
    string PickerOperationId { get; }
  }
}
