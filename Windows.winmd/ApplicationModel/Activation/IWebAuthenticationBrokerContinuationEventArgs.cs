// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IWebAuthenticationBrokerContinuationEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1977459668, 30484, 17725, 183, 255, 185, 94, 58, 23, 9, 218)]
  public interface IWebAuthenticationBrokerContinuationEventArgs : 
    IContinuationActivatedEventArgs,
    IActivatedEventArgs
  {
    WebAuthenticationResult WebAuthenticationResult { get; }
  }
}
