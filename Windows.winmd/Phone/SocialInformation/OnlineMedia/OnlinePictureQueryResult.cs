// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.OnlineMedia.OnlinePictureQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation.OnlineMedia
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public sealed class OnlinePictureQueryResult : IOnlinePictureQueryResult
  {
    [MethodImpl]
    public extern IAsyncOperation<uint> GetPictureCountAsync();

    [Overload("GetPicturesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVector<OnlinePicture>> GetPicturesAsync();

    [Overload("GetPicturesAsyncEx")]
    [MethodImpl]
    public extern IAsyncOperation<IVector<OnlinePicture>> GetPicturesAsync(
      int count);
  }
}
