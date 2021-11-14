// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ICreateAudioGraphResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1414786942, 31710, 19318, 187, 93, 72, 247, 156, 252, 140, 11)]
  [ExclusiveTo(typeof (CreateAudioGraphResult))]
  internal interface ICreateAudioGraphResult
  {
    AudioGraphCreationStatus Status { get; }

    AudioGraph Graph { get; }
  }
}
