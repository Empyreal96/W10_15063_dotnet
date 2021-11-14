// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(356031871, 56280, 18457, 191, 3, 102, 142, 147, 87, 205, 109)]
  public interface IAudioNode : IClosable
  {
    IVector<IAudioEffectDefinition> EffectDefinitions { get; }

    double OutgoingGain { set; get; }

    AudioEncodingProperties EncodingProperties { get; }

    bool ConsumeInput { get; set; }

    void Start();

    void Stop();

    void Reset();

    void DisableEffectsByDefinition(IAudioEffectDefinition definition);

    void EnableEffectsByDefinition(IAudioEffectDefinition definition);
  }
}
