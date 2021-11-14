// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.IEnterpriseKeyCredentialRegistrationInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity
{
  [Guid(942807756, 26411, 18467, 182, 3, 107, 60, 117, 61, 175, 151)]
  [ExclusiveTo(typeof (EnterpriseKeyCredentialRegistrationInfo))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEnterpriseKeyCredentialRegistrationInfo
  {
    string TenantId { get; }

    string TenantName { get; }

    string Subject { get; }

    string KeyId { get; }

    string KeyName { get; }
  }
}
