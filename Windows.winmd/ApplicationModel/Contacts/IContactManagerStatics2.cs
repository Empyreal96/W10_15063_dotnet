// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2709055008, 18392, 18636, 150, 60, 149, 146, 182, 229, 16, 198)]
  internal interface IContactManagerStatics2 : IContactManagerStatics
  {
    [Overload("RequestStoreAsync")]
    [RemoteAsync]
    IAsyncOperation<ContactStore> RequestStoreAsync();
  }
}
