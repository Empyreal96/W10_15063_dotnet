// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IDialReceiverActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4218912471, 34286, 17774, 164, 77, 133, 215, 48, 231, 10, 237)]
  public interface IDialReceiverActivatedEventArgs : ILaunchActivatedEventArgs, IActivatedEventArgs
  {
    string AppName { get; }
  }
}
