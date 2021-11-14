// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceLaneInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [ExclusiveTo(typeof (GuidanceLaneInfo))]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  [Guid(2214908180, 25985, 17335, 172, 21, 201, 7, 155, 249, 13, 241)]
  [WebHostHidden]
  internal interface IGuidanceLaneInfo
  {
    GuidanceLaneMarkers LaneMarkers { get; }

    bool IsOnRoute { get; }
  }
}
