// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IStreetsideExperience
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (StreetsideExperience))]
  [Guid(2774052553, 58124, 18120, 129, 22, 72, 70, 145, 103, 85, 88)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreetsideExperience
  {
    bool AddressTextVisible { get; set; }

    bool CursorVisible { get; set; }

    bool OverviewMapVisible { get; set; }

    bool StreetLabelsVisible { get; set; }

    bool ExitButtonVisible { get; set; }

    bool ZoomButtonsVisible { get; set; }
  }
}
