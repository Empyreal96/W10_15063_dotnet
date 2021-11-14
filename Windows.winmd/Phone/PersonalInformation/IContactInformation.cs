// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IContactInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.PersonalInformation
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(3803521020, 59282, 19127, 177, 91, 242, 224, 120, 102, 77, 234)]
  public interface IContactInformation
  {
    string DisplayName { get; set; }

    string FamilyName { get; set; }

    string GivenName { get; set; }

    string HonorificPrefix { get; set; }

    string HonorificSuffix { get; set; }

    IAsyncOperation<IRandomAccessStream> GetDisplayPictureAsync();

    IAsyncAction SetDisplayPictureAsync(IInputStream stream);

    IRandomAccessStreamReference DisplayPicture { get; }

    [return: HasVariant]
    IAsyncOperation<IMap<string, object>> GetPropertiesAsync();

    [Overload("ToVcardAsync")]
    IAsyncOperation<IRandomAccessStream> ToVcardAsync();

    [Overload("ToVcardWithOptionsAsync")]
    IAsyncOperation<IRandomAccessStream> ToVcardAsync(
      VCardFormat format);
  }
}
