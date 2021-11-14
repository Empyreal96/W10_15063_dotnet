// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactPhone
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100859904)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ContactPhone : IContactPhone
  {
    [MethodImpl]
    public extern ContactPhone();

    public extern string Number { [MethodImpl] get; [MethodImpl] set; }

    public extern ContactPhoneKind Kind { [MethodImpl] get; [MethodImpl] set; }

    public extern string Description { [MethodImpl] get; [MethodImpl] set; }
  }
}
