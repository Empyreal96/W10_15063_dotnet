// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IPropertyPathFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (PropertyPath))]
  [Guid(1313660825, 38950, 20054, 132, 124, 202, 5, 95, 22, 41, 5)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPropertyPathFactory
  {
    PropertyPath CreateInstance(string path);
  }
}
