// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactJobInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactJobInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1829862220, 52816, 19267, 158, 105, 177, 130, 88, 234, 83, 21)]
  internal interface IContactJobInfo
  {
    string CompanyName { get; set; }

    string CompanyYomiName { get; set; }

    string Department { get; set; }

    string Title { get; set; }

    string Manager { get; set; }

    string Office { get; set; }

    string CompanyAddress { get; set; }

    string Description { get; set; }
  }
}
