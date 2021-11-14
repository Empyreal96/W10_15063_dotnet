// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.ContractVersionAttribute
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  [AllowMultiple]
  [AttributeUsage((AttributeTargets) 3967)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public sealed class ContractVersionAttribute : Attribute
  {
    [MethodImpl]
    public extern ContractVersionAttribute(uint version);

    [MethodImpl]
    public extern ContractVersionAttribute(Type contract, uint version);

    [MethodImpl]
    public extern ContractVersionAttribute(string contract, uint version);
  }
}
