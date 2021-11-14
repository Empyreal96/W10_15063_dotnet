// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IFaceDetectedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FaceDetectedEventArgs))]
  [Guid(428966950, 50779, 18106, 133, 248, 19, 136, 5, 118, 201, 10)]
  internal interface IFaceDetectedEventArgs
  {
    FaceDetectionEffectFrame ResultFrame { get; }
  }
}
