// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonArray
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [Guid(146922934, 3261, 19098, 181, 211, 47, 133, 45, 195, 126, 129)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (JsonArray))]
  internal interface IJsonArray : IJsonValue
  {
    JsonObject GetObjectAt(uint index);

    JsonArray GetArrayAt(uint index);

    string GetStringAt(uint index);

    double GetNumberAt(uint index);

    bool GetBooleanAt(uint index);
  }
}
