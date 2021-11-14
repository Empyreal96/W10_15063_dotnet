// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.IPickerClosingOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [ExclusiveTo(typeof (PickerClosingOperation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1290402692, 48878, 20025, 167, 115, 252, 95, 14, 174, 50, 141)]
  internal interface IPickerClosingOperation
  {
    PickerClosingDeferral GetDeferral();

    DateTime Deadline { get; }
  }
}
