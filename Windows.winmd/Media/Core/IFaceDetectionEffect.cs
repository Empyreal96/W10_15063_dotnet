// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IFaceDetectionEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(2920672210, 1346, 17065, 188, 144, 242, 131, 162, 159, 70, 193)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FaceDetectionEffect))]
  internal interface IFaceDetectionEffect : IMediaExtension
  {
    bool Enabled { set; get; }

    TimeSpan DesiredDetectionInterval { set; get; }

    event TypedEventHandler<FaceDetectionEffect, FaceDetectedEventArgs> FaceDetected;
  }
}
