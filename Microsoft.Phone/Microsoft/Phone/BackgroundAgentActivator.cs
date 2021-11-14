// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundAgentActivator
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.ComponentModel;
using System.Reflection;
using System.Security;

namespace Microsoft.Phone
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal class BackgroundAgentActivator : IBackgroundAgentActivator
  {
    BackgroundAgent IBackgroundAgentActivator.CreateBackgroundAgent(
      string assembly,
      string typeinfo)
    {
      return this.LoadAgent(assembly, typeinfo);
    }

    private BackgroundAgent LoadAgent(string assemblyName, string typeName)
    {
      Type type = (this.LoadEntryPointAssembly(assemblyName) ?? throw new InvalidOperationException("Unable to load assembly: " + assemblyName)).GetType(typeName);
      if (type == null)
        throw new InvalidOperationException("Unable to load type " + typeName + "from assembly " + assemblyName);
      Type c = typeof (BackgroundAgent);
      return c == null || type.IsSubclassOf(c) ? (BackgroundAgent) Activator.CreateInstance(type) : throw new InvalidOperationException("specified agent" + typeName + "doesn't derive from BackgroundAgent");
    }

    [SecuritySafeCritical]
    private Assembly LoadEntryPointAssembly(string assemblyName) => Assembly.Load(assemblyName);
  }
}
