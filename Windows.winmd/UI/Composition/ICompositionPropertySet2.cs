// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionPropertySet2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CompositionPropertySet))]
  [Guid(3732960030, 41489, 17493, 136, 128, 125, 15, 63, 106, 68, 253)]
  [WebHostHidden]
  internal interface ICompositionPropertySet2
  {
    void InsertBoolean(string propertyName, bool value);

    CompositionGetValueStatus TryGetBoolean(
      string propertyName,
      out bool value);
  }
}
