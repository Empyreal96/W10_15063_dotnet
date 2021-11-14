// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IMouseWheelParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MouseWheelParameters))]
  [Guid(3939551812, 40429, 16439, 129, 73, 94, 76, 194, 86, 68, 104)]
  internal interface IMouseWheelParameters
  {
    Point CharTranslation { get; set; }

    float DeltaScale { get; set; }

    float DeltaRotationAngle { get; set; }

    Point PageTranslation { get; set; }
  }
}
