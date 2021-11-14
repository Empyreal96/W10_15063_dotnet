// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameFocusControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [ExclusiveTo(typeof (FrameFocusControl))]
  [Guid(657322448, 55570, 16916, 166, 123, 227, 138, 141, 72, 216, 198)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFrameFocusControl
  {
    IReference<uint> Value { get; set; }
  }
}
