// Decompiled with JetBrains decompiler
// Type: Windows.Media.IAudioFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ExclusiveTo(typeof (AudioFrame))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3815424772, 43698, 17015, 158, 208, 67, 206, 223, 142, 41, 198)]
  internal interface IAudioFrame : IMediaFrame, IClosable
  {
    AudioBuffer LockBuffer(AudioBufferAccessMode mode);
  }
}
