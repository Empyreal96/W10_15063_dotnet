// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.ContactBinding
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public sealed class ContactBinding : IClosable, IContactBinding
  {
    [MethodImpl]
    public extern void Close();

    public extern string RemoteId { [MethodImpl] get; }

    public extern string PhoneNumber1 { [MethodImpl] get; [MethodImpl] set; }

    public extern string PhoneNumber2 { [MethodImpl] get; [MethodImpl] set; }

    public extern string PhoneNumber3 { [MethodImpl] get; [MethodImpl] set; }

    public extern string EmailAddress1 { [MethodImpl] get; [MethodImpl] set; }

    public extern string EmailAddress2 { [MethodImpl] get; [MethodImpl] set; }

    public extern string EmailAddress3 { [MethodImpl] get; [MethodImpl] set; }

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern string FirstName { [MethodImpl] get; [MethodImpl] set; }

    public extern string LastName { [MethodImpl] get; [MethodImpl] set; }

    public extern string Identifier { [MethodImpl] get; [MethodImpl] set; }

    public extern string AppBindingAttributes { [MethodImpl] get; [MethodImpl] set; }

    public extern ConnectTileData TileData { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<ConnectTileData> LoadConnectTileDataAsync();
  }
}
