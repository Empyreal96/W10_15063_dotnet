// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextSelectionRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ExclusiveTo(typeof (CoreTextSelectionRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(331769899, 62996, 16922, 143, 75, 158, 200, 165, 163, 127, 205)]
  internal interface ICoreTextSelectionRequestedEventArgs
  {
    CoreTextSelectionRequest Request { get; }
  }
}
