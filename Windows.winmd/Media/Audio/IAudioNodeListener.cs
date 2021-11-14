// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeListener
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Audio
{
  [Guid(3648138774, 3082, 16858, 183, 85, 108, 119, 131, 95, 177, 235)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AudioNodeListener))]
  internal interface IAudioNodeListener
  {
    Vector3 Position { get; set; }

    Quaternion Orientation { get; set; }

    double SpeedOfSound { get; set; }

    Vector3 DopplerVelocity { get; set; }
  }
}
