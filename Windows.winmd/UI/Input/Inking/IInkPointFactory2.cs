// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPointFactory2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(3759431301, 56063, 17906, 173, 105, 5, 13, 130, 86, 162, 9)]
  [ExclusiveTo(typeof (InkPoint))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IInkPointFactory2
  {
    InkPoint CreateInkPointWithTiltAndTimestamp(
      Point position,
      float pressure,
      float tiltX,
      float tiltY,
      ulong timestamp);
  }
}
