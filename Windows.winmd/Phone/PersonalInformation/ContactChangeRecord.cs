// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.ContactChangeRecord
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  public sealed class ContactChangeRecord : IContactChangeRecord
  {
    public extern ContactChangeType ChangeType { [MethodImpl] get; }

    public extern ulong RevisionNumber { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }

    public extern string RemoteId { [MethodImpl] get; }
  }
}
