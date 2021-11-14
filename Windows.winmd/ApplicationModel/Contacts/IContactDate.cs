// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactDate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactDate))]
  [Guid(4271418982, 45573, 18740, 145, 116, 15, 242, 176, 86, 87, 7)]
  internal interface IContactDate
  {
    IReference<uint> Day { get; set; }

    IReference<uint> Month { get; set; }

    IReference<int> Year { get; set; }

    ContactDateKind Kind { get; set; }

    string Description { get; set; }
  }
}
