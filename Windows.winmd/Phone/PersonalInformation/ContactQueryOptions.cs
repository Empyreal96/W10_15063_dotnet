// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.ContactQueryOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Activatable(65536, "Windows.Phone.PhoneContract")]
  public sealed class ContactQueryOptions : IContactQueryOptions
  {
    [MethodImpl]
    public extern ContactQueryOptions();

    public extern IVector<string> DesiredFields { [MethodImpl] get; }

    public extern ContactQueryResultOrdering OrderBy { [MethodImpl] get; [MethodImpl] set; }
  }
}
