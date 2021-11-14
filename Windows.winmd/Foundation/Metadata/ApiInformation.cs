// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.ApiInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IApiInformationStatics), 65536, "Windows.Foundation.FoundationContract")]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public static class ApiInformation
  {
    [MethodImpl]
    public static extern bool IsTypePresent(string typeName);

    [Overload("IsMethodPresent")]
    [MethodImpl]
    public static extern bool IsMethodPresent(string typeName, string methodName);

    [Overload("IsMethodPresentWithArity")]
    [MethodImpl]
    public static extern bool IsMethodPresent(
      string typeName,
      string methodName,
      uint inputParameterCount);

    [MethodImpl]
    public static extern bool IsEventPresent(string typeName, string eventName);

    [MethodImpl]
    public static extern bool IsPropertyPresent(string typeName, string propertyName);

    [MethodImpl]
    public static extern bool IsReadOnlyPropertyPresent(string typeName, string propertyName);

    [MethodImpl]
    public static extern bool IsWriteablePropertyPresent(string typeName, string propertyName);

    [MethodImpl]
    public static extern bool IsEnumNamedValuePresent(string enumTypeName, string valueName);

    [Overload("IsApiContractPresentByMajor")]
    [MethodImpl]
    public static extern bool IsApiContractPresent(string contractName, ushort majorVersion);

    [Overload("IsApiContractPresentByMajorAndMinor")]
    [MethodImpl]
    public static extern bool IsApiContractPresent(
      string contractName,
      ushort majorVersion,
      ushort minorVersion);
  }
}
