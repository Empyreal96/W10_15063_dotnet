// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSourceOpenOperationCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4234685675, 57985, 18300, 168, 224, 26, 205, 101, 65, 20, 200)]
  [ExclusiveTo(typeof (MediaSourceOpenOperationCompletedEventArgs))]
  internal interface IMediaSourceOpenOperationCompletedEventArgs
  {
    MediaSourceError Error { get; }
  }
}
