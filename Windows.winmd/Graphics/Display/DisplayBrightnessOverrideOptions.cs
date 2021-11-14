// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.DisplayBrightnessOverrideOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum DisplayBrightnessOverrideOptions : uint
  {
    None = 0,
    UseDimmedPolicyWhenBatteryIsLow = 1,
  }
}
