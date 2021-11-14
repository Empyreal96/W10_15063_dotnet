// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IHighDynamicRangeControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(1441900462, 55639, 19913, 157, 28, 133, 83, 168, 42, 125, 153)]
  [ExclusiveTo(typeof (HighDynamicRangeControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHighDynamicRangeControl
  {
    bool Enabled { set; get; }
  }
}
