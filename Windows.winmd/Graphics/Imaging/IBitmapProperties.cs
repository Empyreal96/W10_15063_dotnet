// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [Guid(3936309019, 46341, 17488, 164, 209, 232, 202, 148, 82, 157, 141)]
  [ExclusiveTo(typeof (BitmapProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBitmapProperties : IBitmapPropertiesView
  {
    [RemoteAsync]
    IAsyncAction SetPropertiesAsync(
      IIterable<IKeyValuePair<string, BitmapTypedValue>> propertiesToSet);
  }
}
