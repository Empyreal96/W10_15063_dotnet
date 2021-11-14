// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.UserProfile.GameServices.Core.IGameService2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.System.UserProfile.GameServices.Core
{
  [ExclusiveTo(typeof (GameService))]
  [Guid(3526774518, 59927, 19429, 141, 138, 200, 96, 136, 94, 5, 31)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IGameService2
  {
    void NotifyPartnerTokenExpired(Uri audienceUri);

    uint GetAuthenticationStatus();
  }
}
