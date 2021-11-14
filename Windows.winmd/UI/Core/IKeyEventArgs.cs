// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IKeyEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (KeyEventArgs))]
  [WebHostHidden]
  [Guid(1609951536, 9540, 18967, 189, 120, 31, 47, 222, 187, 16, 107)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKeyEventArgs : ICoreWindowEventArgs
  {
    VirtualKey VirtualKey { get; }

    CorePhysicalKeyStatus KeyStatus { get; }
  }
}
