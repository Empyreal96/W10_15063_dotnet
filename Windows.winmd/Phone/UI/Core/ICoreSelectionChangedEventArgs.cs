// Decompiled with JetBrains decompiler
// Type: Windows.Phone.UI.Core.ICoreSelectionChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.UI.Core
{
  [Guid(3264485705, 14677, 20162, 143, 136, 63, 43, 252, 4, 208, 241)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CoreSelectionChangedEventArgs))]
  internal interface ICoreSelectionChangedEventArgs
  {
    uint Start { get; }

    uint Length { get; }
  }
}
