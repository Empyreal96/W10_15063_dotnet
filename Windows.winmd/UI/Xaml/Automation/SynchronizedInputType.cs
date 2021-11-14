// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.SynchronizedInputType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SynchronizedInputType
  {
    KeyUp = 1,
    KeyDown = 2,
    LeftMouseUp = 4,
    LeftMouseDown = 8,
    RightMouseUp = 16, // 0x00000010
    RightMouseDown = 32, // 0x00000020
  }
}
