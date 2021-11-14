// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaExtension
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(126963992, 17887, 17451, 138, 63, 247, 130, 106, 99, 112, 171)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IMediaExtension
  {
    void SetProperties(IPropertySet configuration);
  }
}
