// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ErrorOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ErrorOptions : uint
  {
    None = 0,
    SuppressExceptions = 1,
    ForceExceptions = 2,
    UseSetErrorInfo = 4,
    SuppressSetErrorInfo = 8,
  }
}
