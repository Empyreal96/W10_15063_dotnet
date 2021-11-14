// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.OnlineMedia.IOnlineMediaItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation.OnlineMedia
{
  [Guid(1622096210, 49706, 16663, 161, 113, 192, 3, 200, 153, 127, 183)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public interface IOnlineMediaItem
  {
    string Id { get; }

    string Title { get; set; }

    string RemoteId { get; }

    DateTime CreationTime { get; set; }
  }
}
