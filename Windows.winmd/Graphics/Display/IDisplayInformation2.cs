// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IDisplayInformation2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1305280545, 64209, 19342, 142, 223, 119, 88, 135, 184, 191, 25)]
  [ExclusiveTo(typeof (DisplayInformation))]
  internal interface IDisplayInformation2 : IDisplayInformation
  {
    double RawPixelsPerViewPixel { get; }
  }
}
