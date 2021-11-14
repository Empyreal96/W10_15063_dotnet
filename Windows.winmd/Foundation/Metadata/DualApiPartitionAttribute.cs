// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.DualApiPartitionAttribute
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  [ContractVersion(typeof (FoundationContract), 65536)]
  [AttributeUsage(AttributeTargets.RuntimeClass)]
  public sealed class DualApiPartitionAttribute : Attribute
  {
    public uint version;

    [MethodImpl]
    public extern DualApiPartitionAttribute();
  }
}
