// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IVisibilityChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(3214481642, 55297, 17764, 164, 149, 177, 232, 79, 138, 208, 133)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VisibilityChangedEventArgs))]
  [WebHostHidden]
  internal interface IVisibilityChangedEventArgs : ICoreWindowEventArgs
  {
    bool Visible { get; }
  }
}
