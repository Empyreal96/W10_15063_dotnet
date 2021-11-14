// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.Provisioning.IContactPartnerProvisioningManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation.Provisioning
{
  [ExclusiveTo(typeof (ContactPartnerProvisioningManager))]
  [Guid(3261158903, 21997, 18269, 147, 52, 197, 212, 132, 195, 15, 26)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IContactPartnerProvisioningManagerStatics2
  {
    IAsyncAction AssociateSocialNetworkAccountAsync(
      ContactStore store,
      string networkName,
      string networkAccountId);
  }
}
