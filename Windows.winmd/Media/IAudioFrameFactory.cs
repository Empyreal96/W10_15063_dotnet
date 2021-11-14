// Decompiled with JetBrains decompiler
// Type: Windows.Media.IAudioFrameFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(2443774686, 9250, 16550, 185, 173, 48, 208, 36, 4, 49, 125)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioFrame))]
  internal interface IAudioFrameFactory
  {
    AudioFrame Create([Range(0, 2147483647)] uint capacity);
  }
}
