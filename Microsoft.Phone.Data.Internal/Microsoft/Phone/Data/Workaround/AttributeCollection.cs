// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.Workaround.AttributeCollection
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

using System;
using System.Collections;
using System.Reflection;

namespace Microsoft.Phone.Data.Workaround
{
  public class AttributeCollection : ICollection, IEnumerable
  {
    public static readonly AttributeCollection Empty = new AttributeCollection((Attribute[]) null);
    private Attribute[] attributes;
    private static object internalSyncObject = new object();
    private static Hashtable defaultAttributes;
    private Hashtable foundAttributes;

    public AttributeCollection(Attribute[] attributes)
    {
      if (attributes == null)
        attributes = new Attribute[0];
      this.attributes = attributes;
    }

    public int Count => this.attributes.Length;

    public virtual Attribute this[int index] => this.attributes[index];

    public virtual Attribute this[Type attributeType]
    {
      get
      {
        if (this.foundAttributes == null)
        {
          this.foundAttributes = new Hashtable();
        }
        else
        {
          Attribute foundAttribute = (Attribute) this.foundAttributes[(object) attributeType];
          if (foundAttribute != null)
            return foundAttribute;
        }
        int length = this.attributes.Length;
        for (int index = 0; index < length; ++index)
        {
          Attribute attribute = this.attributes[index];
          if (attribute.GetType() == attributeType)
          {
            this.foundAttributes[(object) attributeType] = (object) attribute;
            return attribute;
          }
        }
        for (int index = 0; index < length; ++index)
        {
          Attribute attribute = this.attributes[index];
          Type type = attribute.GetType();
          if (attributeType.IsAssignableFrom(type))
          {
            this.foundAttributes[(object) attributeType] = (object) attribute;
            return attribute;
          }
        }
        Attribute defaultAttribute = this.GetDefaultAttribute(attributeType);
        if (defaultAttribute != null)
          this.foundAttributes[(object) attributeType] = (object) defaultAttribute;
        return defaultAttribute;
      }
    }

    public bool Contains(Attribute attribute)
    {
      Attribute attribute1 = this[attribute.GetType()];
      return attribute1 != null && attribute1.Equals((object) attribute);
    }

    public bool Contains(Attribute[] attributes)
    {
      if (attributes == null)
        return true;
      for (int index = 0; index < attributes.Length; ++index)
      {
        if (!this.Contains(attributes[index]))
          return false;
      }
      return true;
    }

    protected Attribute GetDefaultAttribute(Type attributeType)
    {
      lock (AttributeCollection.internalSyncObject)
      {
        if (AttributeCollection.defaultAttributes == null)
          AttributeCollection.defaultAttributes = new Hashtable();
        if (AttributeCollection.defaultAttributes.ContainsKey((object) attributeType))
          return (Attribute) AttributeCollection.defaultAttributes[(object) attributeType];
        Attribute attribute = (Attribute) null;
        FieldInfo field = attributeType.GetField("Default");
        if (field != null && field.IsStatic)
        {
          attribute = (Attribute) field.GetValue((object) null);
        }
        else
        {
          ConstructorInfo constructor = attributeType.GetConstructor(new Type[0]);
          if (constructor != null)
            attribute = (Attribute) constructor.Invoke(new object[0]);
        }
        AttributeCollection.defaultAttributes[(object) attributeType] = (object) attribute;
        return attribute;
      }
    }

    public IEnumerator GetEnumerator() => this.attributes.GetEnumerator();

    public bool Matches(Attribute attribute)
    {
      for (int index = 0; index < this.attributes.Length; ++index)
      {
        if (this.attributes[index].Match((object) attribute))
          return true;
      }
      return false;
    }

    public bool Matches(Attribute[] attributes)
    {
      for (int index = 0; index < attributes.Length; ++index)
      {
        if (!this.Matches(attributes[index]))
          return false;
      }
      return true;
    }

    int ICollection.Count => this.Count;

    bool ICollection.IsSynchronized => false;

    object ICollection.SyncRoot => (object) null;

    public void CopyTo(Array array, int index) => Array.Copy((Array) this.attributes, 0, array, index, this.attributes.Length);

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
  }
}
