// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactAnnotation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactAnnotation))]
  [Guid(2183119599, 32065, 17570, 132, 195, 96, 162, 129, 221, 123, 134)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactAnnotation
  {
    string Id { get; }

    string AnnotationListId { get; }

    string ContactId { get; set; }

    string RemoteId { get; set; }

    ContactAnnotationOperations SupportedOperations { get; set; }

    bool IsDisabled { get; }

    ValueSet ProviderProperties { get; }
  }
}
