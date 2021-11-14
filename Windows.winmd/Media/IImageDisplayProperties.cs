// Decompiled with JetBrains decompiler
// Type: Windows.Media.IImageDisplayProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ExclusiveTo(typeof (ImageDisplayProperties))]
  [Guid(3440101359, 21735, 16671, 153, 51, 240, 233, 139, 10, 150, 210)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IImageDisplayProperties
  {
    string Title { get; set; }

    string Subtitle { get; set; }
  }
}
