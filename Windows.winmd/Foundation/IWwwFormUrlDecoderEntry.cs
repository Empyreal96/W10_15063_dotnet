// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IWwwFormUrlDecoderEntry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(308180017, 63096, 20110, 182, 112, 32, 169, 176, 108, 81, 45)]
  public interface IWwwFormUrlDecoderEntry
  {
    string Name { get; }

    string Value { get; }
  }
}
