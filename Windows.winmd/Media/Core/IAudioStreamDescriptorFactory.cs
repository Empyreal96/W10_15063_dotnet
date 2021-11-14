// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IAudioStreamDescriptorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (AudioStreamDescriptor))]
  [Guid(1250348702, 19633, 17280, 142, 12, 131, 80, 75, 127, 91, 243)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioStreamDescriptorFactory
  {
    AudioStreamDescriptor Create(AudioEncodingProperties encodingProperties);
  }
}
