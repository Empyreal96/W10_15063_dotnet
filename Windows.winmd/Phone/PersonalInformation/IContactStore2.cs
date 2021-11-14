// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IContactStore2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [ExclusiveTo(typeof (ContactStore))]
  [Guid(1710339663, 54867, 17319, 178, 54, 179, 12, 15, 77, 114, 105)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IContactStore2
  {
    IAsyncOperation<StoredContact> CreateMeContactAsync(string id);
  }
}
