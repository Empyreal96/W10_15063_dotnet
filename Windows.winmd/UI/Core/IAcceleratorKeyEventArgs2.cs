// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IAcceleratorKeyEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (AcceleratorKeyEventArgs))]
  [Guid(3540036086, 12158, 18547, 165, 85, 22, 110, 89, 110, 225, 197)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IAcceleratorKeyEventArgs2 : ICoreWindowEventArgs
  {
    string DeviceId { get; }
  }
}
