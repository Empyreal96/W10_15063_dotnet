// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IAccessKeyDisplayRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(201825877, 5118, 19715, 166, 29, 225, 47, 6, 86, 114, 134)]
  [ExclusiveTo(typeof (AccessKeyDisplayRequestedEventArgs))]
  internal interface IAccessKeyDisplayRequestedEventArgs
  {
    string PressedKeys { get; }
  }
}
