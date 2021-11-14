// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBarFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1740499780, 8417, 16759, 173, 68, 246, 23, 179, 116, 232, 232)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CommandBar))]
  [WebHostHidden]
  internal interface ICommandBarFactory
  {
    CommandBar CreateInstance(object outer, out object inner);
  }
}
