// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.GuidAttribute
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  [AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Interface)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public sealed class GuidAttribute : Attribute
  {
    [MethodImpl]
    public extern GuidAttribute(
      uint a,
      ushort b,
      ushort c,
      byte d,
      byte e,
      byte f,
      byte g,
      byte h,
      byte i,
      byte j,
      byte k);
  }
}
