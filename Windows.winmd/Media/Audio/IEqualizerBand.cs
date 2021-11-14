// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IEqualizerBand
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EqualizerBand))]
  [Guid(3221903978, 9773, 19333, 155, 183, 67, 40, 11, 98, 237, 12)]
  internal interface IEqualizerBand
  {
    double Bandwidth { get; set; }

    double FrequencyCenter { get; set; }

    double Gain { get; set; }
  }
}
