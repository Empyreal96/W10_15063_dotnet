// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactName
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4093962619, 36916, 17724, 142, 191, 20, 10, 56, 200, 111, 29)]
  [ExclusiveTo(typeof (Contact))]
  internal interface IContactName
  {
    string FirstName { get; set; }

    string LastName { get; set; }

    string MiddleName { get; set; }

    string YomiGivenName { get; set; }

    string YomiFamilyName { get; set; }

    string HonorificNameSuffix { get; set; }

    string HonorificNamePrefix { get; set; }

    string DisplayName { get; }

    string YomiDisplayName { get; }
  }
}
