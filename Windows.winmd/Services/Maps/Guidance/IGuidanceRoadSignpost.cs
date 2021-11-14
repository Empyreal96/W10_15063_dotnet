// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceRoadSignpost
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Services.Maps.Guidance
{
  [ContractVersion(typeof (GuidanceContract), 65536)]
  [Guid(4054263990, 63354, 18242, 131, 18, 83, 48, 15, 152, 69, 240)]
  [ExclusiveTo(typeof (GuidanceRoadSignpost))]
  [WebHostHidden]
  internal interface IGuidanceRoadSignpost
  {
    string ExitNumber { get; }

    string Exit { get; }

    Color BackgroundColor { get; }

    Color ForegroundColor { get; }

    IVectorView<string> ExitDirections { get; }
  }
}
