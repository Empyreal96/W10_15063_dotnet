﻿// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.UINavigationReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public struct UINavigationReading
  {
    public ulong Timestamp;
    public RequiredUINavigationButtons RequiredButtons;
    public OptionalUINavigationButtons OptionalButtons;
  }
}
