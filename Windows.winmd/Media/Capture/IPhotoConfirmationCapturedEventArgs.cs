// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IPhotoConfirmationCapturedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [Guid(2873570930, 49802, 18471, 143, 141, 54, 54, 211, 190, 181, 30)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhotoConfirmationCapturedEventArgs))]
  internal interface IPhotoConfirmationCapturedEventArgs
  {
    CapturedFrame Frame { get; }

    TimeSpan CaptureTimeOffset { get; }
  }
}
