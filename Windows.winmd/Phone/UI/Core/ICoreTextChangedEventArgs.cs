// Decompiled with JetBrains decompiler
// Type: Windows.Phone.UI.Core.ICoreTextChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.UI.Core
{
  [Guid(2117899634, 24804, 20459, 134, 131, 76, 240, 224, 250, 118, 89)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (CoreTextChangedEventArgs))]
  [WebHostHidden]
  internal interface ICoreTextChangedEventArgs
  {
    uint Start { get; }

    uint OldLength { get; }

    string NewText { get; }
  }
}
