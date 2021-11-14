// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ICapturedFrameWithSoftwareBitmap
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CapturedFrame))]
  [Guid(3046017902, 34051, 18869, 158, 134, 137, 125, 38, 163, 255, 61)]
  internal interface ICapturedFrameWithSoftwareBitmap
  {
    SoftwareBitmap SoftwareBitmap { get; }
  }
}
