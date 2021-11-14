// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IPrelaunchActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(205812091, 6647, 18646, 176, 70, 207, 34, 130, 110, 170, 116)]
  public interface IPrelaunchActivatedEventArgs : IActivatedEventArgs
  {
    bool PrelaunchActivated { get; }
  }
}
