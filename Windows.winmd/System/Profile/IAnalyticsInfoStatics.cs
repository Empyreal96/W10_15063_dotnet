// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IAnalyticsInfoStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [ExclusiveTo(typeof (AnalyticsInfo))]
  [Guid(492757094, 6285, 23465, 67, 135, 172, 174, 176, 231, 227, 5)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAnalyticsInfoStatics
  {
    AnalyticsVersionInfo VersionInfo { get; }

    string DeviceForm { get; }
  }
}
