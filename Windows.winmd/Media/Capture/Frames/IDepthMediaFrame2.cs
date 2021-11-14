// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IDepthMediaFrame2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (DepthMediaFrame))]
  [Guid(1825195837, 50340, 16758, 176, 205, 51, 234, 227, 179, 90, 163)]
  internal interface IDepthMediaFrame2
  {
    uint MaxReliableDepth { get; }

    uint MinReliableDepth { get; }
  }
}
