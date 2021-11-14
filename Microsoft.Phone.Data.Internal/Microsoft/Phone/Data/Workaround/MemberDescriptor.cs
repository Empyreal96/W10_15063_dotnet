// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Workaround.MemberDescriptor
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace Microsoft.Phone.Data.Workaround
{
  public abstract class MemberDescriptor
  {
    private string name;
    private string displayName;
    private int nameHash;
    private AttributeCollection attributeCollection;
    private Attribute[] attributes;
    private bool attributesFiltered;
    private bool attributesFilled;
    private string category;
    private string description;

    protected MemberDescriptor(string name)
      : this(name, (Attribute[]) null)
    {
    }

    protected MemberDescriptor(string name, Attribute[] attributes)
    {
      try
      {
        switch (name)
        {
          case "":
          case null:
            throw new ArgumentException(string.Empty, nameof (name));
          default:
            this.name = name;
            this.displayName = name;
            this.nameHash = name.GetHashCode();
            if (attributes == null)
              break;
            this.attributes = attributes;
            this.attributesFiltered = false;
            break;
        }
      }
      catch (Exception ex)
      {
        Debug.Assert(false, ex.ToString());
        throw ex;
      }
    }

    protected MemberDescriptor(MemberDescriptor descr)
    {
      this.name = descr.Name;
      this.displayName = this.name;
      this.nameHash = this.name.GetHashCode();
      this.attributes = descr.attributes != null ? (Attribute[]) descr.attributes.Clone() : (Attribute[]) (object) null;
      this.attributesFiltered = true;
    }

    protected MemberDescriptor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes)
    {
      this.name = oldMemberDescriptor.Name;
      this.displayName = oldMemberDescriptor.DisplayName;
      this.nameHash = this.name.GetHashCode();
      ArrayList arrayList = new ArrayList();
      if (oldMemberDescriptor.attributes != null)
      {
        foreach (object attribute in oldMemberDescriptor.attributes)
          arrayList.Add(attribute);
      }
      if (newAttributes != null)
      {
        foreach (object newAttribute in newAttributes)
          arrayList.Add(newAttribute);
      }
      this.attributes = new Attribute[arrayList.Count];
      arrayList.CopyTo((Array) this.attributes, 0);
      this.attributesFiltered = false;
    }

    protected virtual Attribute[] AttributeArray
    {
      get
      {
        this.FilterAttributesIfNeeded();
        return this.attributes;
      }
      set
      {
        lock (this)
        {
          this.attributes = value;
          this.attributesFiltered = false;
        }
      }
    }

    public virtual AttributeCollection Attributes
    {
      get
      {
        if (this.attributeCollection == null)
          this.attributeCollection = this.CreateAttributeCollection();
        return this.attributeCollection;
      }
    }

    public virtual string Name => this.name == null ? "" : this.name;

    protected virtual int NameHashCode => this.nameHash;

    public virtual string DisplayName => this.displayName;

    protected virtual AttributeCollection CreateAttributeCollection() => new AttributeCollection(this.AttributeArray);

    public override bool Equals(object obj)
    {
      if (this == obj)
        return true;
      if (obj == null || obj.GetType() != this.GetType())
        return false;
      MemberDescriptor memberDescriptor = (MemberDescriptor) obj;
      this.FilterAttributesIfNeeded();
      memberDescriptor.FilterAttributesIfNeeded();
      if (memberDescriptor.nameHash != this.nameHash || memberDescriptor.category == null != (this.category == null) || this.category != null && !memberDescriptor.category.Equals(this.category) || (memberDescriptor.description == null != (this.description == null) || this.description != null && !memberDescriptor.category.Equals(this.description)) || memberDescriptor.attributes == null != (this.attributes == null))
        return false;
      bool flag = true;
      if (this.attributes != null)
      {
        if (this.attributes.Length != memberDescriptor.attributes.Length)
          return false;
        for (int index = 0; index < this.attributes.Length; ++index)
        {
          if (!this.attributes[index].Equals((object) memberDescriptor.attributes[index]))
          {
            flag = false;
            break;
          }
        }
      }
      return flag;
    }

    protected virtual void FillAttributes(IList attributeList)
    {
      if (this.attributes == null)
        return;
      foreach (Attribute attribute in this.attributes)
        attributeList.Add((object) attribute);
    }

    private void FilterAttributesIfNeeded()
    {
      if (this.attributesFiltered)
        return;
      IList attributeList;
      if (!this.attributesFilled)
      {
        attributeList = (IList) new ArrayList();
        try
        {
          this.FillAttributes(attributeList);
        }
        catch (Exception ex)
        {
          switch (ex)
          {
            case ThreadAbortException _:
            case StackOverflowException _:
            case OutOfMemoryException _:
              throw;
            default:
              Debug.Assert(false, this.name + ">>" + ex.ToString());
              break;
          }
        }
      }
      else
        attributeList = (IList) new ArrayList((ICollection) this.attributes);
      Hashtable hashtable = new Hashtable(attributeList.Count);
      foreach (Attribute attribute in (IEnumerable) attributeList)
        hashtable[(object) attribute.GetType()] = (object) attribute;
      Attribute[] attributeArray = new Attribute[hashtable.Values.Count];
      hashtable.Values.CopyTo((Array) attributeArray, 0);
      lock (this)
      {
        this.attributes = attributeArray;
        this.attributesFiltered = true;
        this.attributesFilled = true;
      }
    }

    protected static MethodInfo FindMethod(
      Type componentClass,
      string name,
      Type[] args,
      Type returnType)
    {
      return MemberDescriptor.FindMethod(componentClass, name, args, returnType, true);
    }

    protected static MethodInfo FindMethod(
      Type componentClass,
      string name,
      Type[] args,
      Type returnType,
      bool publicOnly)
    {
      MethodInfo methodInfo = !publicOnly ? componentClass.GetMethod(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, args, (ParameterModifier[]) null) : componentClass.GetMethod(name, args);
      if (methodInfo != null && methodInfo.ReturnType != returnType)
        methodInfo = (MethodInfo) null;
      return methodInfo;
    }

    public override int GetHashCode() => base.GetHashCode();
  }
}
