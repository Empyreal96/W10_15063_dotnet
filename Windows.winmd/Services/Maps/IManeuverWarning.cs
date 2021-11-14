// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IManeuverWarning
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(3248713098, 9776, 17272, 158, 74, 110, 68, 37, 61, 206, 186)]
  [ExclusiveTo(typeof (ManeuverWarning))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  internal interface IManeuverWarning
  {
    ManeuverWarningKind Kind { get; }

    ManeuverWarningSeverity Severity { get; }
  }
}
