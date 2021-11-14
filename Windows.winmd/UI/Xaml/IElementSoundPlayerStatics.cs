// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IElementSoundPlayerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (ElementSoundPlayer))]
  [Guid(561680388, 38941, 16841, 177, 82, 173, 169, 17, 164, 177, 58)]
  [WebHostHidden]
  internal interface IElementSoundPlayerStatics
  {
    double Volume { get; set; }

    ElementSoundPlayerState State { get; set; }

    void Play(ElementSoundKind sound);
  }
}
