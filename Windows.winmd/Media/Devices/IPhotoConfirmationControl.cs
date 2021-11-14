// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IPhotoConfirmationControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  [Guid(3371430755, 65374, 17794, 169, 168, 5, 80, 248, 90, 74, 118)]
  [ExclusiveTo(typeof (PhotoConfirmationControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPhotoConfirmationControl
  {
    bool Supported { get; }

    bool Enabled { get; set; }

    MediaPixelFormat PixelFormat { get; set; }
  }
}
