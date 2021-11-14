// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.DeprecatedAttribute
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  [AllowMultiple]
  [AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.RuntimeClass | AttributeTargets.Struct)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public sealed class DeprecatedAttribute : Attribute
  {
    [MethodImpl]
    public extern DeprecatedAttribute(string message, DeprecationType type, uint version);

    [MethodImpl]
    public extern DeprecatedAttribute(
      string message,
      DeprecationType type,
      uint version,
      Platform platform);

    [MethodImpl]
    public extern DeprecatedAttribute(
      string message,
      DeprecationType type,
      uint version,
      string contract);
  }
}
