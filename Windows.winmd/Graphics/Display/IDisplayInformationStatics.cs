// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IDisplayInformationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [ExclusiveTo(typeof (DisplayInformation))]
  [Guid(3332385388, 54354, 17628, 186, 7, 150, 243, 198, 173, 249, 209)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDisplayInformationStatics
  {
    DisplayInformation GetForCurrentView();

    DisplayOrientations AutoRotationPreferences { get; set; }

    event TypedEventHandler<DisplayInformation, object> DisplayContentsInvalidated;
  }
}
