// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactEmail
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2426542505, 58323, 19811, 153, 59, 5, 185, 165, 57, 58, 191)]
  [ExclusiveTo(typeof (ContactEmail))]
  internal interface IContactEmail
  {
    string Address { get; set; }

    ContactEmailKind Kind { get; set; }

    string Description { get; set; }
  }
}
