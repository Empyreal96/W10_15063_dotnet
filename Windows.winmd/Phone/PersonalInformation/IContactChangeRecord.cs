// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IContactChangeRecord
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [ExclusiveTo(typeof (ContactChangeRecord))]
  [Guid(3117676431, 20795, 18242, 190, 0, 204, 92, 92, 35, 107, 4)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IContactChangeRecord
  {
    ContactChangeType ChangeType { get; }

    ulong RevisionNumber { get; }

    string Id { get; }

    string RemoteId { get; }
  }
}
