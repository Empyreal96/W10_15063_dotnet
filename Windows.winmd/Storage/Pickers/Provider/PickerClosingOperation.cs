﻿// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.PickerClosingOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PickerClosingOperation : IPickerClosingOperation
  {
    [MethodImpl]
    public extern PickerClosingDeferral GetDeferral();

    public extern DateTime Deadline { [MethodImpl] get; }
  }
}
