// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ITargetPropertyPath
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1081347982, 2143, 19693, 190, 112, 111, 71, 172, 241, 90, 208)]
  [ExclusiveTo(typeof (TargetPropertyPath))]
  [WebHostHidden]
  internal interface ITargetPropertyPath
  {
    PropertyPath Path { get; set; }

    object Target { get; set; }
  }
}
