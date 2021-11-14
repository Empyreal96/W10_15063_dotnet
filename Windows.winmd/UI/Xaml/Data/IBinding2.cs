// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IBinding2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Binding))]
  [Guid(888762315, 1030, 18611, 158, 130, 243, 51, 236, 76, 105, 16)]
  internal interface IBinding2
  {
    object FallbackValue { get; set; }

    object TargetNullValue { get; set; }

    UpdateSourceTrigger UpdateSourceTrigger { get; set; }
  }
}
