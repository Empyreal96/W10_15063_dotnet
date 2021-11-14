// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioGraphUnrecoverableErrorOccurredEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (AudioGraphUnrecoverableErrorOccurredEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3285830624, 16374, 20403, 178, 98, 80, 212, 53, 197, 84, 35)]
  internal interface IAudioGraphUnrecoverableErrorOccurredEventArgs
  {
    AudioGraphUnrecoverableError Error { get; }
  }
}
