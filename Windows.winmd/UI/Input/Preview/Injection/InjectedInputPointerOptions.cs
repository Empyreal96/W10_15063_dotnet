// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputPointerOptions
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
  public enum InjectedInputPointerOptions : uint
  {
    None = 0,
    New = 1,
    InRange = 2,
    InContact = 4,
    FirstButton = 16, // 0x00000010
    SecondButton = 32, // 0x00000020
    Primary = 8192, // 0x00002000
    Confidence = 16384, // 0x00004000
    Canceled = 32768, // 0x00008000
    PointerDown = 65536, // 0x00010000
    Update = 131072, // 0x00020000
    PointerUp = 262144, // 0x00040000
    CaptureChanged = 2097152, // 0x00200000
  }
}
