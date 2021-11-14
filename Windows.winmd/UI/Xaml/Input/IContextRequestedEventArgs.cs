// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IContextRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ContextRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1113689610, 7350, 18171, 131, 116, 10, 236, 104, 170, 94, 81)]
  internal interface IContextRequestedEventArgs
  {
    bool Handled { get; set; }

    bool TryGetPosition(UIElement relativeTo, out Point point);
  }
}
