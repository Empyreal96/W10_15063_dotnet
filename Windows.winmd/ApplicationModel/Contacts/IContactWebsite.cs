// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactWebsite
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactWebsite))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2668822902, 56347, 16469, 173, 102, 101, 47, 57, 217, 144, 232)]
  internal interface IContactWebsite
  {
    Uri Uri { get; set; }

    string Description { get; set; }
  }
}
