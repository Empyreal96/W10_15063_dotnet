// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IProtocolForResultsActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Activation
{
  [Guid(3880858306, 31463, 17687, 128, 172, 219, 232, 215, 204, 91, 156)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IProtocolForResultsActivatedEventArgs : IActivatedEventArgs
  {
    ProtocolForResultsOperation ProtocolForResultsOperation { get; }
  }
}
