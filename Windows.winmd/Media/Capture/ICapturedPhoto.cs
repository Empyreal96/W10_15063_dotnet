// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ICapturedPhoto
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (CapturedPhoto))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2966322778, 53196, 19820, 138, 209, 8, 105, 32, 138, 202, 22)]
  internal interface ICapturedPhoto
  {
    CapturedFrame Frame { get; }

    CapturedFrame Thumbnail { get; }
  }
}
