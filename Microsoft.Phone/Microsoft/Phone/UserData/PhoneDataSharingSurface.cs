// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.PhoneDataSharingSurface
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Collections.Generic;

namespace Microsoft.Phone.UserData
{
  internal static class PhoneDataSharingSurface
  {
    private static Dictionary<string, PhoneDataSharingProvider> _providers;

    private static Dictionary<string, PhoneDataSharingProvider> Providers
    {
      get
      {
        if (PhoneDataSharingSurface._providers == null)
          PhoneDataSharingSurface._providers = new Dictionary<string, PhoneDataSharingProvider>();
        return PhoneDataSharingSurface._providers;
      }
    }

    public static bool ProviderAlreadyRegistered(string baseUri) => PhoneDataSharingSurface.Providers.ContainsKey(baseUri);

    public static void RegisterProvider(PhoneDataSharingProvider provider)
    {
      lock (PhoneDataSharingSurface._providers)
      {
        if (PhoneDataSharingSurface.ProviderAlreadyRegistered(provider.BaseUri))
          return;
        PhoneDataSharingSurface.Providers.Add(provider.BaseUri, provider);
      }
    }

    public static IEnumerable<TElement> ExecuteRequest<TElement>(
      string baseUri,
      string query)
    {
      IEnumerable<TElement> elements = (IEnumerable<TElement>) null;
      if (PhoneDataSharingSurface.ProviderAlreadyRegistered(baseUri))
        elements = PhoneDataSharingSurface._providers[baseUri].GetObjects<TElement>(query);
      return elements;
    }
  }
}
