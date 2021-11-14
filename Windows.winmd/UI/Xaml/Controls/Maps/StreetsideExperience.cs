// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.StreetsideExperience
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [Activatable(typeof (IStreetsideExperienceFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StreetsideExperience : MapCustomExperience, IStreetsideExperience
  {
    [MethodImpl]
    public extern StreetsideExperience(StreetsidePanorama panorama);

    [MethodImpl]
    public extern StreetsideExperience(
      StreetsidePanorama panorama,
      double headingInDegrees,
      double pitchInDegrees,
      double fieldOfViewInDegrees);

    public extern bool AddressTextVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CursorVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool OverviewMapVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool StreetLabelsVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ExitButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool ZoomButtonsVisible { [MethodImpl] get; [MethodImpl] set; }
  }
}
