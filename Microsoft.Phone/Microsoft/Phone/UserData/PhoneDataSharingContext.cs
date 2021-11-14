// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.PhoneDataSharingContext
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;

namespace Microsoft.Phone.UserData
{
  public class PhoneDataSharingContext
  {
    private string _baseUri;
    private PoomDataServiceInteropContext _Interop = new PoomDataServiceInteropContext();

    protected string BaseUri => this._baseUri;

    protected void InitializeInteropContext() => PhoneDataSharingContext.MapHrToException(this._Interop.Init());

    internal static void MapHrToException(uint hr)
    {
      if (hr == 0U)
        return;
      if (hr == 2147942405U)
        throw new UnauthorizedAccessException("Access to personal information requires ID_CAP_CONTACTS or ID_CAP_APPOINTMENTS defined in the manifest");
      throw new Exception("Operation failed: " + hr.ToString("X"));
    }

    protected PhoneDataSharingContext(string baseUri) => this._baseUri = !string.IsNullOrEmpty(baseUri) ? baseUri : throw new ArgumentNullException(nameof (baseUri));

    protected IEnumerable<T> ExecuteRequest<T>(string query) => PhoneDataSharingSurface.ExecuteRequest<T>(this.BaseUri, query);
  }
}
