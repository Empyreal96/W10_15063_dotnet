// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.IEnterpriseKeyCredentialRegistrationManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity
{
  [Guid(2213789247, 41567, 19642, 187, 142, 189, 195, 45, 3, 194, 151)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EnterpriseKeyCredentialRegistrationManager))]
  internal interface IEnterpriseKeyCredentialRegistrationManager
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<EnterpriseKeyCredentialRegistrationInfo>> GetRegistrationsAsync();
  }
}
