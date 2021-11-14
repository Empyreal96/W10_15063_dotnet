// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactAnnotation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactAnnotation : IContactAnnotation, IContactAnnotation2
  {
    [MethodImpl]
    public extern ContactAnnotation();

    public extern string Id { [MethodImpl] get; }

    public extern string AnnotationListId { [MethodImpl] get; }

    public extern string ContactId { [MethodImpl] get; [MethodImpl] set; }

    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    public extern ContactAnnotationOperations SupportedOperations { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsDisabled { [MethodImpl] get; }

    public extern ValueSet ProviderProperties { [MethodImpl] get; }

    public extern string ContactListId { [MethodImpl] get; [MethodImpl] set; }
  }
}
