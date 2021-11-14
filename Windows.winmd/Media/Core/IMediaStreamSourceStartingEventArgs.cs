// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceStartingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4094978290, 49780, 18752, 165, 187, 40, 165, 114, 69, 47, 167)]
  [ExclusiveTo(typeof (MediaStreamSourceStartingEventArgs))]
  internal interface IMediaStreamSourceStartingEventArgs
  {
    MediaStreamSourceStartingRequest Request { get; }
  }
}
