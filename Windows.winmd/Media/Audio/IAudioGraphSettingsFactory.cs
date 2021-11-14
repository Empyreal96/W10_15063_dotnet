// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioGraphSettingsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Render;

namespace Windows.Media.Audio
{
  [Guid(2782469318, 49899, 19041, 162, 20, 29, 102, 215, 95, 131, 218)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AudioGraphSettings))]
  internal interface IAudioGraphSettingsFactory
  {
    AudioGraphSettings Create(AudioRenderCategory audioRenderCategory);
  }
}
