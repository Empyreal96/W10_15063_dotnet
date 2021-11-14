// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.IApiInformationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

namespace Windows.Foundation.Metadata
{
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(2574531070, 63105, 18961, 180, 22, 193, 58, 71, 232, 186, 54)]
  [ExclusiveTo(typeof (ApiInformation))]
  internal interface IApiInformationStatics
  {
    bool IsTypePresent(string typeName);

    [Overload("IsMethodPresent")]
    bool IsMethodPresent(string typeName, string methodName);

    [Overload("IsMethodPresentWithArity")]
    bool IsMethodPresent(string typeName, string methodName, uint inputParameterCount);

    bool IsEventPresent(string typeName, string eventName);

    bool IsPropertyPresent(string typeName, string propertyName);

    bool IsReadOnlyPropertyPresent(string typeName, string propertyName);

    bool IsWriteablePropertyPresent(string typeName, string propertyName);

    bool IsEnumNamedValuePresent(string enumTypeName, string valueName);

    [Overload("IsApiContractPresentByMajor")]
    bool IsApiContractPresent(string contractName, ushort majorVersion);

    [Overload("IsApiContractPresentByMajorAndMinor")]
    bool IsApiContractPresent(string contractName, ushort majorVersion, ushort minorVersion);
  }
}
