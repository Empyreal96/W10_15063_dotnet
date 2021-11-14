// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardCryptogramMaterialType
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 131072)]
  public enum SmartCardCryptogramMaterialType
  {
    None,
    StaticDataAuthentication,
    TripleDes112,
    Aes,
    RsaPkcs1,
  }
}
