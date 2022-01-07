using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MarsRover.Extension
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum GenericEnum)
        {
            var genericEnumType = GenericEnum.GetType();
            var memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
            if (memberInfo.Length > 0)
            {
                var attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if ((attributes.Any()))
                {
                    return ((DescriptionAttribute)attributes.ElementAt(0)).Description;
                }
            }
            return GenericEnum.ToString();
        }
    }
}
