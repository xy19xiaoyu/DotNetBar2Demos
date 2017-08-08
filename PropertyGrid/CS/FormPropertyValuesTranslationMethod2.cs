using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace PropertyGrid
{
    public partial class FormPropertyValuesTranslationMethod2 : DevComponents.DotNetBar.Office2007Form
    {
        public FormPropertyValuesTranslationMethod2()
        {
            InitializeComponent();
        }

        private PropertySettings _BackImageLayoutPropertySetting = null;
        private Dictionary<ImageLayout, string> _Values = new Dictionary<ImageLayout, string>();
        private void FormPropertyValuesTranslationMethod2_Load(object sender, EventArgs e)
        {
            // Initialize the value mapping collection
            _Values.Add(ImageLayout.Center, "Center Image");
            _Values.Add(ImageLayout.None, "As is");
            _Values.Add(ImageLayout.Stretch, "Stretch Image");
            _Values.Add(ImageLayout.Tile, "Tile Image");
            _Values.Add(ImageLayout.Zoom, "Zoom Image");

            // Initialize property setting object
            _BackImageLayoutPropertySetting = new PropertySettings("BackgroundImageLayout");
            // Handling these 3 events is needed for proper value mapping
            _BackImageLayoutPropertySetting.ConvertFromStringToPropertyValue += new ConvertValueEventHandler(BackImageLayoutConvertFromStringToPropertyValue);
            _BackImageLayoutPropertySetting.ConvertPropertyValueToString += new ConvertValueEventHandler(BackImageLayoutConvertPropertyValueToString);
            _BackImageLayoutPropertySetting.ProvidePropertyValueList += new PropertyValueListEventHandler(BackImageLayoutProvidePropertyValueList);

            // Create new visual style for property node so we can see it better
            _BackImageLayoutPropertySetting.Style = new ElementStyle();
            _BackImageLayoutPropertySetting.Style.TextColor = Color.DarkRed;
            // Add property setting to the grid
            advPropertyGrid1.PropertySettings.Add(_BackImageLayoutPropertySetting);

            // Set object to display properties for
            advPropertyGrid1.SelectedObject = buttonX1;
        }

        void BackImageLayoutProvidePropertyValueList(object sender, PropertyValueListEventArgs e)
        {
            // This list is used for auto-complete while typing the property value
            // as well as for drop-down Combo-Box 
            e.ValueList = new List<string>(_Values.Values);
            e.IsListValid = true;
        }

        void BackImageLayoutConvertPropertyValueToString(object sender, ConvertValueEventArgs e)
        {
            // Convert typed value to its text representation
            if (e.TypedValue == null)
                e.StringValue = "";
            else
                e.StringValue = _Values[(ImageLayout)e.TypedValue];
            e.IsConverted = true;
        }

        void BackImageLayoutConvertFromStringToPropertyValue(object sender, ConvertValueEventArgs e)
        {
            // Convert text representation to the typed value
            string value = (e.StringValue ?? "").ToLower();

            foreach (KeyValuePair<ImageLayout, string> item in _Values)
            {
                if (item.Value.ToLower() == value)
                {
                    e.TypedValue = item.Key;
                    e.IsConverted = true;
                    break;
                }
            }
        }
    }
}