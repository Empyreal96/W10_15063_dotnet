// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IContactBinding
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [Guid(3061350376, 54891, 14954, 143, 90, 96, 116, 102, 213, 77, 12)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (ContactBinding))]
  internal interface IContactBinding
  {
    string RemoteId { get; }

    string PhoneNumber1 { get; set; }

    string PhoneNumber2 { get; set; }

    string PhoneNumber3 { get; set; }

    string EmailAddress1 { get; set; }

    string EmailAddress2 { get; set; }

    string EmailAddress3 { get; set; }

    string Name { get; set; }

    string FirstName { get; set; }

    string LastName { get; set; }

    string Identifier { get; set; }

    string AppBindingAttributes { get; set; }

    ConnectTileData TileData { set; get; }

    IAsyncOperation<ConnectTileData> LoadConnectTileDataAsync();
  }
}
