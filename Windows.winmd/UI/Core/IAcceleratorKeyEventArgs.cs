// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IAcceleratorKeyEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AcceleratorKeyEventArgs))]
  [Guid(4280044618, 37511, 18187, 131, 110, 144, 134, 227, 18, 106, 222)]
  internal interface IAcceleratorKeyEventArgs : ICoreWindowEventArgs
  {
    CoreAcceleratorKeyEventType EventType { get; }

    VirtualKey VirtualKey { get; }

    CorePhysicalKeyStatus KeyStatus { get; }
  }
}
