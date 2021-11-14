// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayerEffects
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2241978074, 51894, 19648, 139, 227, 96, 53, 244, 222, 37, 145)]
  [ExclusiveTo(typeof (MediaPlayer))]
  internal interface IMediaPlayerEffects
  {
    void AddAudioEffect(string activatableClassId, bool effectOptional, IPropertySet configuration);

    void RemoveAllEffects();
  }
}
