// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneDialOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Contacts;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ExclusiveTo(typeof (PhoneDialOptions))]
  [Guid(3057239224, 61551, 14027, 168, 99, 130, 55, 66, 181, 242, 212)]
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  internal interface IPhoneDialOptions
  {
    string Number { get; set; }

    string DisplayName { get; set; }

    Contact Contact { get; set; }

    ContactPhone ContactPhone { get; set; }

    PhoneCallMedia Media { get; set; }

    PhoneAudioRoutingEndpoint AudioEndpoint { get; set; }
  }
}
