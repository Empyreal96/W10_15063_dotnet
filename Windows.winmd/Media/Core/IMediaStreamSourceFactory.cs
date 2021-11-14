// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MediaStreamSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4017610969, 53592, 19322, 134, 63, 32, 51, 66, 251, 253, 65)]
  internal interface IMediaStreamSourceFactory
  {
    MediaStreamSource CreateFromDescriptor(IMediaStreamDescriptor descriptor);

    MediaStreamSource CreateFromDescriptors(
      IMediaStreamDescriptor descriptor,
      IMediaStreamDescriptor descriptor2);
  }
}
