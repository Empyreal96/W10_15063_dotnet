// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.PhotoConfirmationControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class PhotoConfirmationControl : IPhotoConfirmationControl
  {
    public extern bool Supported { [MethodImpl] get; }

    public extern bool Enabled { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaPixelFormat PixelFormat { [MethodImpl] get; [MethodImpl] set; }
  }
}
