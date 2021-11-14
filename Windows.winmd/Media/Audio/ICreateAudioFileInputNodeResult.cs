// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ICreateAudioFileInputNodeResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (CreateAudioFileInputNodeResult))]
  [Guid(3464746524, 58007, 19536, 156, 231, 28, 122, 105, 214, 189, 9)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICreateAudioFileInputNodeResult
  {
    AudioFileNodeCreationStatus Status { get; }

    AudioFileInputNode FileInputNode { get; }
  }
}
