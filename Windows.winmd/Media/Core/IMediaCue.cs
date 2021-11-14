// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaCue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(3352387165, 23004, 17183, 160, 238, 39, 116, 67, 35, 179, 109)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IMediaCue
  {
    TimeSpan StartTime { set; get; }

    TimeSpan Duration { set; get; }

    string Id { set; get; }
  }
}
