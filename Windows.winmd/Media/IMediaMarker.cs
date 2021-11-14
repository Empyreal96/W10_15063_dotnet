// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaMarker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(402906872, 56485, 19311, 156, 32, 227, 211, 192, 100, 54, 37)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IMediaMarker
  {
    TimeSpan Time { get; }

    string MediaMarkerType { get; }

    string Text { get; }
  }
}
