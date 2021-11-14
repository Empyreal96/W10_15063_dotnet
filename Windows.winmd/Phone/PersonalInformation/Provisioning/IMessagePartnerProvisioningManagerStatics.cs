// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.Provisioning.IMessagePartnerProvisioningManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation.Provisioning
{
  [Guid(2317027408, 29637, 17788, 188, 89, 237, 125, 97, 92, 5, 164)]
  [ExclusiveTo(typeof (MessagePartnerProvisioningManager))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IMessagePartnerProvisioningManagerStatics
  {
    IAsyncAction ImportSmsToSystemAsync(
      bool incoming,
      bool read,
      string body,
      string sender,
      IVectorView<string> recipients,
      DateTime deliveryTime);

    IAsyncAction ImportMmsToSystemAsync(
      bool incoming,
      bool read,
      string subject,
      string sender,
      IVectorView<string> recipients,
      DateTime deliveryTime,
      [HasVariant] IVectorView<IMapView<string, object>> attachments);
  }
}
