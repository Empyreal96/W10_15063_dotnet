// Decompiled with JetBrains decompiler
// Type: Windows.Media.IVideoDisplayProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ExclusiveTo(typeof (VideoDisplayProperties))]
  [Guid(1443495345, 23853, 18546, 129, 112, 69, 222, 229, 188, 47, 92)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVideoDisplayProperties
  {
    string Title { get; set; }

    string Subtitle { get; set; }
  }
}
