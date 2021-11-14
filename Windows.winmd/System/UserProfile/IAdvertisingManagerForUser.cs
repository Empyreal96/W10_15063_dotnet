// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IAdvertisingManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2458645456, 53116, 19120, 167, 220, 109, 197, 188, 212, 66, 82)]
  [ExclusiveTo(typeof (AdvertisingManagerForUser))]
  internal interface IAdvertisingManagerForUser
  {
    string AdvertisingId { get; }

    User User { get; }
  }
}
