// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceTelemetryCollectorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [WebHostHidden]
  [Guid(911417415, 61792, 17659, 181, 120, 148, 87, 124, 160, 89, 144)]
  [ExclusiveTo(typeof (GuidanceTelemetryCollector))]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  internal interface IGuidanceTelemetryCollectorStatics
  {
    GuidanceTelemetryCollector GetCurrent();
  }
}
