// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSourceStateChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(170962818, 36977, 19372, 188, 57, 202, 42, 147, 183, 23, 169)]
  [ExclusiveTo(typeof (MediaSourceStateChangedEventArgs))]
  internal interface IMediaSourceStateChangedEventArgs
  {
    MediaSourceState OldState { get; }

    MediaSourceState NewState { get; }
  }
}
