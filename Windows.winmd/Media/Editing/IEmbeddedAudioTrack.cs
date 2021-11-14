// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IEmbeddedAudioTrack
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Editing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmbeddedAudioTrack))]
  [Guid(1441684090, 11568, 16314, 161, 144, 79, 26, 100, 84, 248, 143)]
  internal interface IEmbeddedAudioTrack
  {
    AudioEncodingProperties GetAudioEncodingProperties();
  }
}
