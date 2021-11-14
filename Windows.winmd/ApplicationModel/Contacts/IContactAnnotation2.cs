// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactAnnotation2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactAnnotation))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3063016691, 19127, 18975, 153, 65, 12, 156, 243, 23, 27, 117)]
  internal interface IContactAnnotation2
  {
    string ContactListId { get; set; }
  }
}
