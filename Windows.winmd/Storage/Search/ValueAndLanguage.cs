﻿// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.ValueAndLanguage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ValueAndLanguage : IValueAndLanguage
  {
    [MethodImpl]
    public extern ValueAndLanguage();

    public extern string Language { [MethodImpl] get; [MethodImpl] set; }

    public extern object Value { [MethodImpl] [return: Variant] get; [MethodImpl] [param: Variant] set; }
  }
}
