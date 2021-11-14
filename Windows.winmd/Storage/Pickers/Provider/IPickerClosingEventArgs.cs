// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Pickers.Provider.IPickerClosingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Pickers.Provider
{
  [ExclusiveTo(typeof (PickerClosingEventArgs))]
  [Guid(2119823908, 45874, 20242, 139, 159, 168, 194, 240, 107, 50, 205)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPickerClosingEventArgs
  {
    PickerClosingOperation ClosingOperation { get; }

    bool IsCanceled { get; }
  }
}
