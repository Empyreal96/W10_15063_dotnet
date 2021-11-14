// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Management.Deployment.EnterpriseStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Management.Deployment
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [WebHostHidden]
  public enum EnterpriseStatus
  {
    Enrolled,
    Disabled,
    Revoked,
    Expired,
  }
}
