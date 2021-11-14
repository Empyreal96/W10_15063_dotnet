// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IContactStoreStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (ContactStore))]
  [Guid(2818899490, 19435, 17612, 165, 114, 103, 165, 185, 46, 133, 103)]
  internal interface IContactStoreStatics
  {
    [Overload("CreateOrOpenAsync")]
    IAsyncOperation<ContactStore> CreateOrOpenAsync();

    [Overload("CreateOrOpenWithOptionsAsync")]
    IAsyncOperation<ContactStore> CreateOrOpenAsync(
      ContactStoreSystemAccessMode access,
      ContactStoreApplicationAccessMode sharing);
  }
}
