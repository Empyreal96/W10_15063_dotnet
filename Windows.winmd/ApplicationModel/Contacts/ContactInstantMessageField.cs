// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactInstantMessageField
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IContactInstantMessageFieldFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactInstantMessageField : IContactInstantMessageField, IContactField
  {
    [MethodImpl]
    public extern ContactInstantMessageField(string userName);

    [MethodImpl]
    public extern ContactInstantMessageField(string userName, ContactFieldCategory category);

    [MethodImpl]
    public extern ContactInstantMessageField(
      string userName,
      ContactFieldCategory category,
      string service,
      string displayText,
      Uri verb);

    public extern string UserName { [MethodImpl] get; }

    public extern string Service { [MethodImpl] get; }

    public extern string DisplayText { [MethodImpl] get; }

    public extern Uri LaunchUri { [MethodImpl] get; }

    public extern ContactFieldType Type { [MethodImpl] get; }

    public extern ContactFieldCategory Category { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    public extern string Value { [MethodImpl] get; }
  }
}
