// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerEffects2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaPlayer))]
  [Guid(4198603385, 7102, 18117, 174, 31, 142, 230, 159, 179, 194, 199)]
  internal interface IMediaPlayerEffects2
  {
    void AddVideoEffect(
      string activatableClassId,
      bool effectOptional,
      IPropertySet effectConfiguration);
  }
}
