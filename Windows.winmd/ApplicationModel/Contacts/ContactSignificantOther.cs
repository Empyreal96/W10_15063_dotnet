// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactSignificantOther
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactSignificantOther : IContactSignificantOther, IContactSignificantOther2
  {
    [MethodImpl]
    public extern ContactSignificantOther();

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    public extern ContactRelationship Relationship { [MethodImpl] get; [MethodImpl] set; }
  }
}
