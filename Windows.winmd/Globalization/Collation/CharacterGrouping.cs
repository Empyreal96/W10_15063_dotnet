﻿// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Collation.CharacterGrouping
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.Collation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CharacterGrouping : ICharacterGrouping
  {
    public extern string First { [MethodImpl] get; }

    public extern string Label { [MethodImpl] get; }
  }
}
