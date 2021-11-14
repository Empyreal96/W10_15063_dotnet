// Decompiled with JetBrains decompiler
// Type: Windows.Phone.SocialInformation.OnlineMedia.IOnlineMediaManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.SocialInformation.OnlineMedia
{
  [Guid(1699090429, 25207, 18671, 181, 197, 107, 129, 240, 99, 56, 251)]
  [ExclusiveTo(typeof (OnlineMediaManager))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface IOnlineMediaManagerStatics
  {
    IAsyncOperation<OnlineMediaManager> RequestMediaManagerAsync();
  }
}
