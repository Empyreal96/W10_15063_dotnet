// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.QueryDataEnumerable`1
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Microsoft.Phone.UserData
{
  [SecuritySafeCritical]
  internal class QueryDataEnumerable<T> : IEnumerable<T>, IEnumerable
  {
    private IInteropContext _interopContext;
    private IElementSerializer<T> _serializer;
    private string _queryUri;
    private uint _optimalBatchSize;
    private List<T> _objectCache;
    private object _nativeEnumerator;
    private bool _nativeEnumerationDone;

    public QueryDataEnumerable(
      IInteropContext interopContext,
      IElementSerializer<T> serializer,
      string queryUri)
    {
      if (interopContext == null)
        throw new ArgumentNullException(nameof (interopContext));
      if (serializer == null)
        throw new ArgumentNullException(nameof (serializer));
      if (string.IsNullOrEmpty(queryUri))
        throw new ArgumentNullException(nameof (queryUri));
      this._interopContext = interopContext;
      this._serializer = serializer;
      this._queryUri = queryUri;
      this._objectCache = new List<T>();
    }

    ~QueryDataEnumerable()
    {
      if (this._interopContext != null && this._nativeEnumerator != null)
      {
        this._interopContext.FreeEnumerator(this._nativeEnumerator);
        this._nativeEnumerator = (object) null;
      }
      this._interopContext = (IInteropContext) null;
      this._serializer = (IElementSerializer<T>) null;
      this._queryUri = (string) null;
      this._objectCache = (List<T>) null;
    }

    public IEnumerator<T> GetEnumerator() => (IEnumerator<T>) new QueryDataEnumerator<T>(this);

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

    private void EnsureInteropInit()
    {
      if (this._nativeEnumerator != null || this._nativeEnumerationDone)
        return;
      PhoneDataSharingContext.MapHrToException(this._interopContext.Init());
      this._optimalBatchSize = this._interopContext.GetOptimalBatchSize();
      PhoneDataSharingContext.MapHrToException(this._interopContext.GetObjectsEnumerator(this._queryUri, out this._nativeEnumerator));
    }

    internal bool GetNextBatch(int nextIndex)
    {
      bool flag = false;
      if (nextIndex >= this._objectCache.Count)
      {
        if (!this._nativeEnumerationDone)
        {
          this.EnsureInteropInit();
          object[] objectHandles = (object[]) null;
          PhoneDataSharingContext.MapHrToException(this._interopContext.MoveNext(this._nativeEnumerator, this._optimalBatchSize, ref objectHandles));
          if (objectHandles != null)
          {
            if (objectHandles.Length != 0)
            {
              try
              {
                foreach (object current in objectHandles)
                  this._objectCache.Add(this._serializer.GetObject(current));
              }
              finally
              {
                foreach (object handle in objectHandles)
                  this._interopContext.FreeObject(handle);
              }
              flag = true;
              goto label_14;
            }
          }
          this._nativeEnumerationDone = true;
          this._interopContext.FreeEnumerator(this._nativeEnumerator);
          this._nativeEnumerator = (object) null;
          GC.SuppressFinalize((object) this);
        }
      }
      else
        flag = true;
label_14:
      return flag;
    }

    internal List<T> ObjectCache => this._objectCache;
  }
}
