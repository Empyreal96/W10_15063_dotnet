// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailQueryOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(1162890139, 15999, 19794, 182, 221, 214, 253, 78, 31, 189, 154)]
  [ExclusiveTo(typeof (EmailQueryOptions))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailQueryOptions
  {
    EmailQueryTextSearch TextSearch { get; }

    EmailQuerySortDirection SortDirection { get; set; }

    EmailQuerySortProperty SortProperty { get; set; }

    EmailQueryKind Kind { get; set; }

    IVector<string> FolderIds { get; }
  }
}
