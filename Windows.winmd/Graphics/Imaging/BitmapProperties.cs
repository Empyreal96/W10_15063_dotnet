// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BitmapProperties : IBitmapProperties, IBitmapPropertiesView
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetPropertiesAsync(
      IIterable<IKeyValuePair<string, BitmapTypedValue>> propertiesToSet);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<BitmapPropertySet> GetPropertiesAsync(
      IIterable<string> propertiesToRetrieve);
  }
}
