// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapPropertiesView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [Guid(2114971770, 14960, 18680, 156, 85, 25, 108, 245, 165, 69, 245)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IBitmapPropertiesView
  {
    [RemoteAsync]
    IAsyncOperation<BitmapPropertySet> GetPropertiesAsync(
      IIterable<string> propertiesToRetrieve);
  }
}
