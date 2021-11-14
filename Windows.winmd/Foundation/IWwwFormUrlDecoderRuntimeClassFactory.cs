// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IWwwFormUrlDecoderRuntimeClassFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ExclusiveTo(typeof (WwwFormUrlDecoder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1535929149, 9390, 16821, 161, 191, 240, 195, 213, 68, 132, 91)]
  internal interface IWwwFormUrlDecoderRuntimeClassFactory
  {
    WwwFormUrlDecoder CreateWwwFormUrlDecoder(string query);
  }
}
