// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactQueryOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactQueryOptions))]
  [Guid(1141427358, 32124, 17136, 138, 199, 245, 7, 51, 236, 219, 193)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactQueryOptions
  {
    ContactQueryTextSearch TextSearch { get; }

    IVector<string> ContactListIds { get; }

    bool IncludeContactsFromHiddenLists { get; set; }

    ContactQueryDesiredFields DesiredFields { get; set; }

    ContactAnnotationOperations DesiredOperations { get; set; }

    IVector<string> AnnotationListIds { get; }
  }
}
