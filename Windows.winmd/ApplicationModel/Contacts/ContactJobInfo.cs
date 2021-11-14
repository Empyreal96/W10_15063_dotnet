// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactJobInfo
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
  public sealed class ContactJobInfo : IContactJobInfo
  {
    [MethodImpl]
    public extern ContactJobInfo();

    public extern string CompanyName { [MethodImpl] get; [MethodImpl] set; }

    public extern string CompanyYomiName { [MethodImpl] get; [MethodImpl] set; }

    public extern string Department { [MethodImpl] get; [MethodImpl] set; }

    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern string Manager { [MethodImpl] get; [MethodImpl] set; }

    public extern string Office { [MethodImpl] get; [MethodImpl] set; }

    public extern string CompanyAddress { [MethodImpl] get; [MethodImpl] set; }

    public extern string Description { [MethodImpl] get; [MethodImpl] set; }
  }
}
