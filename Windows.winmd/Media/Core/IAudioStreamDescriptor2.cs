// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IAudioStreamDescriptor2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (AudioStreamDescriptor))]
  [Guid(778629622, 42056, 18811, 136, 64, 133, 8, 38, 101, 172, 249)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAudioStreamDescriptor2 : IMediaStreamDescriptor
  {
    IReference<uint> LeadingEncoderPadding { set; get; }

    IReference<uint> TrailingEncoderPadding { set; get; }
  }
}
