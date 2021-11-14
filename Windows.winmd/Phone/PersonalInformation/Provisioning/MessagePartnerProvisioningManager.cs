// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.Provisioning.MessagePartnerProvisioningManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation.Provisioning
{
  [Static(typeof (IMessagePartnerProvisioningManagerStatics), 65536, "Windows.Phone.PhoneContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  public static class MessagePartnerProvisioningManager
  {
    [MethodImpl]
    public static extern IAsyncAction ImportSmsToSystemAsync(
      bool incoming,
      bool read,
      string body,
      string sender,
      IVectorView<string> recipients,
      DateTime deliveryTime);

    [MethodImpl]
    public static extern IAsyncAction ImportMmsToSystemAsync(
      bool incoming,
      bool read,
      string subject,
      string sender,
      IVectorView<string> recipients,
      DateTime deliveryTime,
      [HasVariant] IVectorView<IMapView<string, object>> attachments);
  }
}
