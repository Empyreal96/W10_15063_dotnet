// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.OnlineMedia.IOnlinePictureQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation.OnlineMedia
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (OnlinePictureQueryResult))]
  [Guid(1170283316, 50067, 19266, 168, 217, 214, 228, 105, 16, 30, 109)]
  internal interface IOnlinePictureQueryResult
  {
    IAsyncOperation<uint> GetPictureCountAsync();

    [Overload("GetPicturesAsync")]
    IAsyncOperation<IVector<OnlinePicture>> GetPicturesAsync();

    [Overload("GetPicturesAsyncEx")]
    IAsyncOperation<IVector<OnlinePicture>> GetPicturesAsync(
      int count);
  }
}
