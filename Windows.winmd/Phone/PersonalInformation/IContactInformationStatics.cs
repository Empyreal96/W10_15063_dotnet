// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IContactInformationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.PersonalInformation
{
  [Guid(258456361, 976, 19430, 178, 165, 251, 19, 133, 159, 18, 2)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (ContactInformation))]
  internal interface IContactInformationStatics
  {
    IAsyncOperation<ContactInformation> ParseVcardAsync(
      IInputStream vcard);
  }
}
