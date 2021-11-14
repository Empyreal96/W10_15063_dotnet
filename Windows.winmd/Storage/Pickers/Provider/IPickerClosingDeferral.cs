// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.IPickerClosingDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [Guid(2063071006, 6759, 18993, 174, 128, 233, 7, 112, 138, 97, 155)]
  [ExclusiveTo(typeof (PickerClosingDeferral))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPickerClosingDeferral
  {
    void Complete();
  }
}
