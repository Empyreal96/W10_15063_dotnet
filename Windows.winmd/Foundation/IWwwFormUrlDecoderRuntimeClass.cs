// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IWwwFormUrlDecoderRuntimeClass
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ExclusiveTo(typeof (WwwFormUrlDecoder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3562669137, 61989, 17730, 146, 150, 14, 29, 245, 210, 84, 223)]
  internal interface IWwwFormUrlDecoderRuntimeClass : 
    IIterable<IWwwFormUrlDecoderEntry>,
    IVectorView<IWwwFormUrlDecoderEntry>
  {
    string GetFirstValueByName(string name);
  }
}
