// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactConnectedServiceAccount
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
  public sealed class ContactConnectedServiceAccount : IContactConnectedServiceAccount
  {
    [MethodImpl]
    public extern ContactConnectedServiceAccount();

    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    public extern string ServiceName { [MethodImpl] get; [MethodImpl] set; }
  }
}
