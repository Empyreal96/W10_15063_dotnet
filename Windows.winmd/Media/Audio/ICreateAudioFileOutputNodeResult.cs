// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ICreateAudioFileOutputNodeResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (CreateAudioFileOutputNodeResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1205254779, 59657, 17727, 134, 110, 85, 64, 205, 167, 52, 255)]
  internal interface ICreateAudioFileOutputNodeResult
  {
    AudioFileNodeCreationStatus Status { get; }

    AudioFileOutputNode FileOutputNode { get; }
  }
}
