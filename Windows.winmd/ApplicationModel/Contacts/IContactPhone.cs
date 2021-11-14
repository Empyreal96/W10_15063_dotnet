// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactPhone
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(1182640997, 10002, 20306, 183, 131, 158, 168, 17, 28, 99, 205)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactPhone))]
  internal interface IContactPhone
  {
    string Number { get; set; }

    ContactPhoneKind Kind { get; set; }

    string Description { get; set; }
  }
}
