// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ISpeechCue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (SpeechCue))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2934068444, 5925, 19373, 128, 67, 169, 132, 153, 176, 23, 162)]
  internal interface ISpeechCue : IMediaCue
  {
    string Text { get; set; }

    IReference<int> StartPositionInInput { get; set; }

    IReference<int> EndPositionInInput { get; set; }
  }
}
