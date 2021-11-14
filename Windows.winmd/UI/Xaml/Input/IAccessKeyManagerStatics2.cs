// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IAccessKeyManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (AccessKeyManager))]
  [Guid(2519446932, 10931, 18373, 149, 75, 112, 146, 243, 85, 247, 151)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  internal interface IAccessKeyManagerStatics2
  {
    bool AreKeyTipsEnabled { get; set; }
  }
}
