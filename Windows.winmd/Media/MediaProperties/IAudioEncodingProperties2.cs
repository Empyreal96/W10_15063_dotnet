// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IAudioEncodingProperties2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3294450906, 32957, 19491, 128, 213, 114, 212, 161, 129, 232, 148)]
  [ExclusiveTo(typeof (AudioEncodingProperties))]
  internal interface IAudioEncodingProperties2
  {
    bool IsSpatial { get; }
  }
}
