// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.Provisioning.ContactPartnerProvisioningManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.PersonalInformation.Provisioning
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IContactPartnerProvisioningManagerStatics), 65536, "Windows.Phone.PhoneContract")]
  [Static(typeof (IContactPartnerProvisioningManagerStatics2), 65536, "Windows.Phone.PhoneContract")]
  public static class ContactPartnerProvisioningManager
  {
    [MethodImpl]
    public static extern IAsyncAction AssociateNetworkAccountAsync(
      ContactStore store,
      string networkName,
      string networkAccountId);

    [MethodImpl]
    public static extern IAsyncAction ImportVcardToSystemAsync(IInputStream stream);

    [MethodImpl]
    public static extern IAsyncAction AssociateSocialNetworkAccountAsync(
      ContactStore store,
      string networkName,
      string networkAccountId);
  }
}
