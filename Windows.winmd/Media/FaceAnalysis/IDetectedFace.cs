// Decompiled with JetBrains decompiler
// Type: Windows.Media.FaceAnalysis.IDetectedFace
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.FaceAnalysis
{
  [ExclusiveTo(typeof (DetectedFace))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2181092436, 26300, 13535, 148, 16, 232, 148, 0, 25, 84, 20)]
  internal interface IDetectedFace
  {
    BitmapBounds FaceBox { get; }
  }
}
