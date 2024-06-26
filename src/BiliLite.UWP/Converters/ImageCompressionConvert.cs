﻿using BiliLite.Services;
using System;
using Windows.UI.Xaml.Data;

namespace BiliLite.Converters
{
    public class ImageCompressionConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
            {
                return "ms-appx:///Assets/Thumbnails/Placeholde.png";
            }
            if (SettingService.UI.LoadOriginalImage.Value)
            {
                return value;
            }
            if (value.ToString().Contains("@"))
            {
                return value;
            }
            if (parameter == null) return value;
            return value.ToString() + "@" + parameter.ToString() + ".png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value;
        }
    }
}
