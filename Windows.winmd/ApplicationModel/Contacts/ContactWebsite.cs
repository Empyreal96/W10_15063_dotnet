// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactWebsite
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactWebsite : IContactWebsite, IContactWebsite2
  {
    [MethodImpl]
    public extern ContactWebsite();

    public extern Uri Uri { [MethodImpl] get; [MethodImpl] set; }

    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    public extern string RawValue { [MethodImpl] get; [MethodImpl] set; }
  }
}
