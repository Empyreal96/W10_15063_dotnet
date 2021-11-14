// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.ISecondaryAuthenticationFactorRegistration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Identity.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (SecondaryAuthenticationFactorRegistration))]
  [Guid(2672606132, 36026, 18608, 132, 13, 219, 178, 42, 84, 198, 120)]
  internal interface ISecondaryAuthenticationFactorRegistration
  {
    [RemoteAsync]
    IAsyncAction FinishRegisteringDeviceAsync(IBuffer deviceConfigurationData);

    [RemoteAsync]
    IAsyncAction AbortRegisteringDeviceAsync(string errorLogMessage);
  }
}
