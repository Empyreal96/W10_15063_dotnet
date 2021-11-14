// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.GuidanceRoadSignpost
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Services.Maps.Guidance
{
  [ContractVersion(typeof (GuidanceContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GuidanceRoadSignpost : IGuidanceRoadSignpost
  {
    public extern string ExitNumber { [MethodImpl] get; }

    public extern string Exit { [MethodImpl] get; }

    public extern Color BackgroundColor { [MethodImpl] get; }

    public extern Color ForegroundColor { [MethodImpl] get; }

    public extern IVectorView<string> ExitDirections { [MethodImpl] get; }
  }
}
