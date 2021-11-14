// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardCryptogramPlacementStep
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 131072)]
  [ExclusiveTo(typeof (SmartCardCryptogramPlacementStep))]
  [Guid(2491089899, 33602, 18322, 162, 229, 146, 86, 54, 55, 138, 83)]
  internal interface ISmartCardCryptogramPlacementStep
  {
    SmartCardCryptogramAlgorithm Algorithm { get; set; }

    IBuffer SourceData { get; set; }

    string CryptogramMaterialPackageName { get; set; }

    string CryptogramMaterialName { get; set; }

    int TemplateOffset { get; set; }

    int CryptogramOffset { get; set; }

    int CryptogramLength { get; set; }

    SmartCardCryptogramPlacementOptions CryptogramPlacementOptions { get; set; }

    SmartCardCryptogramPlacementStep ChainedOutputStep { get; set; }
  }
}
