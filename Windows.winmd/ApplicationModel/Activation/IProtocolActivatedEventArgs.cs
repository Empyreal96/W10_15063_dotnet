// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IProtocolActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1620440285, 47040, 18091, 129, 254, 217, 15, 54, 208, 13, 36)]
  public interface IProtocolActivatedEventArgs : IActivatedEventArgs
  {
    Uri Uri { get; }
  }
}
