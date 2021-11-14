// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GameServiceContainer
// Assembly: Microsoft.Xna.Framework.Game, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 6EBDB755-3EEE-4715-BDC3-9A6D92805A5E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIBB65~1.DLL

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
  public class GameServiceContainer : IServiceProvider
  {
    private Dictionary<Type, object> services = new Dictionary<Type, object>();

    public void AddService(Type type, object provider)
    {
      if (type == null)
        throw new ArgumentNullException(nameof (type), Resources.ServiceTypeCannotBeNull);
      if (provider == null)
        throw new ArgumentNullException(nameof (provider), Resources.ServiceProviderCannotBeNull);
      if (this.services.ContainsKey(type))
        throw new ArgumentException(Resources.ServiceAlreadyPresent, nameof (type));
      if (!type.IsAssignableFrom(provider.GetType()))
        throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentUICulture, Resources.ServiceMustBeAssignable, (object) provider.GetType().FullName, (object) type.GetType().FullName));
      this.services.Add(type, provider);
    }

    public void RemoveService(Type type)
    {
      if (type == null)
        throw new ArgumentNullException(nameof (type), Resources.ServiceTypeCannotBeNull);
      this.services.Remove(type);
    }

    public object GetService(Type type)
    {
      if (type == null)
        throw new ArgumentNullException(nameof (type), Resources.ServiceTypeCannotBeNull);
      return this.services.ContainsKey(type) ? this.services[type] : (object) null;
    }
  }
}
