// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IInputScopeNameFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InputScopeName))]
  [WebHostHidden]
  [Guid(1245756242, 19415, 20052, 134, 23, 28, 218, 138, 30, 218, 127)]
  internal interface IInputScopeNameFactory
  {
    InputScopeName CreateInstance(InputScopeNameValue nameValue);
  }
}
