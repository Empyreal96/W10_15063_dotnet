// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioGraphConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (AudioGraphConnection))]
  [Guid(1982886125, 53326, 20396, 178, 51, 96, 11, 66, 237, 212, 105)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioGraphConnection
  {
    IAudioNode Destination { get; }

    double Gain { set; get; }
  }
}
