// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IAudioStreamDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (AudioStreamDescriptor))]
  [Guid(506893028, 16423, 18503, 167, 11, 223, 29, 154, 42, 123, 4)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioStreamDescriptor : IMediaStreamDescriptor
  {
    AudioEncodingProperties EncodingProperties { get; }
  }
}
