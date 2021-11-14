// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IAdvertisingManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ExclusiveTo(typeof (AdvertisingManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2916304524, 41587, 18635, 179, 70, 53, 68, 82, 45, 85, 129)]
  internal interface IAdvertisingManagerStatics
  {
    string AdvertisingId { get; }
  }
}
