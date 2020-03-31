using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infraestructure.Utils.Utils
{
    public class HelperAdapter<E, D>
        where E : class
        where D : class
    {
        public static E ConvertToVMO(D model)
        {
            var vmo = Activator.CreateInstance(typeof(E));
            var Properties = vmo.GetType().GetProperties().ToList();
            var ModelProperties = model.GetType().GetProperties().ToList();
            foreach (var property in Properties)
            {
                PropertyTargetAttribute Attribute = (PropertyTargetAttribute)property.GetCustomAttributes(typeof(PropertyTargetAttribute), true).FirstOrDefault();
                if (Attribute != null)
                {
                    var ModelProperty = ModelProperties.FirstOrDefault(x => x.Name == Attribute.PropertyName);
                    if (ModelProperty != null)
                    {
                        var value = ModelProperty.GetValue(model);
                        vmo.GetType().GetProperty(property.Name).SetValue(vmo, value);
                    }
                }
            }

            return (E)vmo;
        }

        public static D ConvertToNewModel(E vmo)
        {
            var model = Activator.CreateInstance(typeof(D));
            var Properties = vmo.GetType().GetProperties().ToList();
            var ModelProperties = model.GetType().GetProperties().ToList();
            foreach (var property in Properties)
            {
                PropertyTargetAttribute Attribute = (PropertyTargetAttribute)property.GetCustomAttributes(typeof(PropertyTargetAttribute), true).FirstOrDefault();
                if (Attribute != null)
                {
                    var ModelProperty = ModelProperties.FirstOrDefault(x => x.Name == Attribute.PropertyName);
                    if (ModelProperty != null)
                    {
                        var value = property.GetValue(vmo);
                        model.GetType().GetProperty(ModelProperty.Name).SetValue(model, value);
                    }
                }
            }

            return (D)model;
        }
        public static D ConvertToModel(E vmo, D model)
        {
            var Properties = vmo.GetType().GetProperties().ToList();
            var ModelProperties = model.GetType().GetProperties().ToList();
            foreach (var property in Properties)
            {
                PropertyTargetAttribute Attribute = (PropertyTargetAttribute)property.GetCustomAttributes(typeof(PropertyTargetAttribute), true).FirstOrDefault();
                if (Attribute != null)
                {
                    var ModelProperty = ModelProperties.FirstOrDefault(x => x.Name == Attribute.PropertyName);
                    if (ModelProperty != null)
                    {
                        var value = property.GetValue(vmo);
                        model.GetType().GetProperty(ModelProperty.Name).SetValue(model, value);
                    }
                }
            }

            return (D)model;
        }

    }

}
