// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactQueryOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IContactQueryOptionsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactQueryOptions : IContactQueryOptions
  {
    [MethodImpl]
    public extern ContactQueryOptions(string text);

    [MethodImpl]
    public extern ContactQueryOptions(string text, ContactQuerySearchFields fields);

    [MethodImpl]
    public extern ContactQueryOptions();

    public extern ContactQueryTextSearch TextSearch { [MethodImpl] get; }

    public extern IVector<string> ContactListIds { [MethodImpl] get; }

    public extern bool IncludeContactsFromHiddenLists { [MethodImpl] get; [MethodImpl] set; }

    public extern ContactQueryDesiredFields DesiredFields { [MethodImpl] get; [MethodImpl] set; }

    public extern ContactAnnotationOperations DesiredOperations { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> AnnotationListIds { [MethodImpl] get; }
  }
}
