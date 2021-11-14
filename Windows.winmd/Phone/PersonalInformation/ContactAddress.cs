// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.ContactAddress
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Activatable(65536, "Windows.Phone.PhoneContract")]
  public sealed class ContactAddress : IContactAddress
  {
    [MethodImpl]
    public extern ContactAddress();

    public extern string Country { [MethodImpl] get; [MethodImpl] set; }

    public extern string Locality { [MethodImpl] get; [MethodImpl] set; }

    public extern string Region { [MethodImpl] get; [MethodImpl] set; }

    public extern string PostalCode { [MethodImpl] get; [MethodImpl] set; }

    public extern string StreetAddress { [MethodImpl] get; [MethodImpl] set; }
  }
}
