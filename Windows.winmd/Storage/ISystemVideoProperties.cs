// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISystemVideoProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(541128469, 26616, 17186, 155, 128, 79, 169, 254, 251, 131, 232)]
  [ExclusiveTo(typeof (SystemVideoProperties))]
  internal interface ISystemVideoProperties
  {
    string Director { get; }

    string FrameHeight { get; }

    string FrameWidth { get; }

    string Orientation { get; }

    string TotalBitrate { get; }
  }
}
