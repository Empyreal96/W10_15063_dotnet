// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.IEnterpriseKeyCredentialRegistrationManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EnterpriseKeyCredentialRegistrationManager))]
  [Guid(2008571550, 44276, 19392, 186, 194, 64, 187, 70, 239, 187, 63)]
  internal interface IEnterpriseKeyCredentialRegistrationManagerStatics
  {
    EnterpriseKeyCredentialRegistrationManager Current { get; }
  }
}
