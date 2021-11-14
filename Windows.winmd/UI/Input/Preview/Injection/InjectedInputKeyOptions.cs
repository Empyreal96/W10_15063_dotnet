// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputKeyOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum InjectedInputKeyOptions : uint
  {
    None = 0,
    ExtendedKey = 1,
    KeyUp = 2,
    ScanCode = 8,
    Unicode = 4,
  }
}
