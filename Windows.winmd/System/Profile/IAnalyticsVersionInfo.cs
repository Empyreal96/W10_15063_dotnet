// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IAnalyticsVersionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2455843000, 39253, 19572, 189, 193, 124, 208, 222, 207, 155, 3)]
  [ExclusiveTo(typeof (AnalyticsVersionInfo))]
  internal interface IAnalyticsVersionInfo
  {
    string DeviceFamily { get; }

    string DeviceFamilyVersion { get; }
  }
}
