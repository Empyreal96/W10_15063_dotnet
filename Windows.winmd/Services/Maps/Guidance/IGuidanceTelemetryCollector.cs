// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceTelemetryCollector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [WebHostHidden]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  [ExclusiveTo(typeof (GuidanceTelemetryCollector))]
  [Guid(3676278181, 47224, 19858, 152, 221, 52, 125, 35, 211, 130, 98)]
  internal interface IGuidanceTelemetryCollector
  {
    bool Enabled { get; set; }

    void ClearLocalData();

    double SpeedTrigger { get; set; }

    int UploadFrequency { get; set; }
  }
}
