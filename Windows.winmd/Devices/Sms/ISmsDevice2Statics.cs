// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsDevice2Statics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [Guid(1707574053, 4145, 18718, 143, 182, 239, 153, 145, 175, 227, 99)]
  [ExclusiveTo(typeof (SmsDevice2))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmsDevice2Statics
  {
    string GetDeviceSelector();

    SmsDevice2 FromId(string deviceId);

    SmsDevice2 GetDefault();

    SmsDevice2 FromParentId(string parentDeviceId);
  }
}
