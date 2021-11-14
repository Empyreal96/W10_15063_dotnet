// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonErrorStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1077948634, 34768, 17260, 131, 171, 252, 123, 18, 192, 204, 38)]
  [ExclusiveTo(typeof (JsonError))]
  internal interface IJsonErrorStatics2
  {
    JsonErrorStatus GetJsonStatus(int hresult);
  }
}
