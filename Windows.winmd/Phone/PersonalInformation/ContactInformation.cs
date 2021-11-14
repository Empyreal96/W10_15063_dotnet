// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.ContactInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.PersonalInformation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IContactInformationStatics), 65536, "Windows.Phone.PhoneContract")]
  [Activatable(65536, "Windows.Phone.PhoneContract")]
  [ContractVersion(typeof (PhoneContract), 65536)]
  public sealed class ContactInformation : IContactInformation
  {
    [MethodImpl]
    public extern ContactInformation();

    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern string FamilyName { [MethodImpl] get; [MethodImpl] set; }

    public extern string GivenName { [MethodImpl] get; [MethodImpl] set; }

    public extern string HonorificPrefix { [MethodImpl] get; [MethodImpl] set; }

    public extern string HonorificSuffix { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> GetDisplayPictureAsync();

    [MethodImpl]
    public extern IAsyncAction SetDisplayPictureAsync(IInputStream stream);

    public extern IRandomAccessStreamReference DisplayPicture { [MethodImpl] get; }

    [MethodImpl]
    [return: HasVariant]
    public extern IAsyncOperation<IMap<string, object>> GetPropertiesAsync();

    [Overload("ToVcardAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> ToVcardAsync();

    [Overload("ToVcardWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> ToVcardAsync(
      VCardFormat format);

    [MethodImpl]
    public static extern IAsyncOperation<ContactInformation> ParseVcardAsync(
      IInputStream vcard);
  }
}
