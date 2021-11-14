// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.Provisioning.IContactPartnerProvisioningManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.PersonalInformation.Provisioning
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (ContactPartnerProvisioningManager))]
  [Guid(3235355169, 431, 20435, 152, 205, 179, 214, 86, 222, 21, 244)]
  internal interface IContactPartnerProvisioningManagerStatics
  {
    IAsyncAction AssociateNetworkAccountAsync(
      ContactStore store,
      string networkName,
      string networkAccountId);

    IAsyncAction ImportVcardToSystemAsync(IInputStream stream);
  }
}
