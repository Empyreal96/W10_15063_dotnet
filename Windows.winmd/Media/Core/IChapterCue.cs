// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IChapterCue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1923710977, 54154, 19466, 143, 166, 117, 205, 218, 244, 102, 76)]
  [ExclusiveTo(typeof (ChapterCue))]
  internal interface IChapterCue : IMediaCue
  {
    string Title { set; get; }
  }
}
