// Decompiled with JetBrains decompiler
// Type: Windows.Media.IVideoDisplayProperties2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3021005262, 43858, 16811, 164, 134, 204, 16, 250, 177, 82, 249)]
  [ExclusiveTo(typeof (VideoDisplayProperties))]
  internal interface IVideoDisplayProperties2
  {
    IVector<string> Genres { get; }
  }
}
