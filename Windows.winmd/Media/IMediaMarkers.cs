// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaMarkers
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(2951393673, 63709, 18030, 170, 16, 146, 11, 82, 53, 63, 223)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IMediaMarkers
  {
    IVectorView<IMediaMarker> Markers { get; }
  }
}
