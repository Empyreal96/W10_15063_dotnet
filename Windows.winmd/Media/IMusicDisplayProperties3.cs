// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMusicDisplayProperties3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(1303714497, 1665, 20108, 148, 1, 184, 21, 157, 158, 239, 199)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MusicDisplayProperties))]
  internal interface IMusicDisplayProperties3
  {
    uint AlbumTrackCount { get; set; }
  }
}
