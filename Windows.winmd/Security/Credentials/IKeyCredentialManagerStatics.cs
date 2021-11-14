// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IKeyCredentialManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1789675147, 3825, 19680, 130, 144, 65, 6, 218, 106, 99, 181)]
  [ExclusiveTo(typeof (KeyCredentialManager))]
  internal interface IKeyCredentialManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<bool> IsSupportedAsync();

    [RemoteAsync]
    IAsyncAction RenewAttestationAsync();

    IAsyncOperation<KeyCredentialRetrievalResult> RequestCreateAsync(
      string name,
      KeyCredentialCreationOption option);

    [RemoteAsync]
    IAsyncOperation<KeyCredentialRetrievalResult> OpenAsync(
      string name);

    [RemoteAsync]
    IAsyncAction DeleteAsync(string name);
  }
}
