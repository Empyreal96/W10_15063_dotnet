// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IAdvertisingManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3708372911, 6765, 18096, 149, 188, 243, 249, 214, 190, 185, 251)]
  [ExclusiveTo(typeof (AdvertisingManager))]
  internal interface IAdvertisingManagerStatics2
  {
    AdvertisingManagerForUser GetForUser(User user);
  }
}
