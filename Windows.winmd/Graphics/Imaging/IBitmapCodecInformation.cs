// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapCodecInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ExclusiveTo(typeof (BitmapCodecInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1074572018, 50352, 17298, 163, 176, 111, 111, 155, 169, 92, 180)]
  internal interface IBitmapCodecInformation
  {
    Guid CodecId { get; }

    IVectorView<string> FileExtensions { get; }

    string FriendlyName { get; }

    IVectorView<string> MimeTypes { get; }
  }
}
