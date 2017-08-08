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
    public partial class FormPropertyValuesTranslationMethod1 : DevComponents.DotNetBar.Office2007Form
    {
        public FormPropertyValuesTranslationMethod1()
        {
            InitializeComponent();
        }

        // By handling AdvPropertyGrid events you can perform "bulk" property value conversions
        // For example apply it to all boolean properties.
        private const string Text_Yes = "Yes";
        private const string Text_No = "No";
        
        // Convert typed property value to its text representation
        private void advPropertyGrid1_ConvertPropertyValueToString(object sender, ConvertValueEventArgs e)
        {
            if (e.PropertyDescriptor.PropertyType == typeof(bool))
            {
                if ((bool)e.TypedValue == true)
                    e.StringValue = Text_Yes;
                else
                    e.StringValue = Text_No;
                // Note that you must indicate that you have converted the value
                e.IsConverted = true;
            }
        }

        // Convert the property value text representation to typed value
        private void advPropertyGrid1_ConvertFromStringToPropertyValue(object sender, ConvertValueEventArgs e)
        {
            if (e.PropertyDescriptor.PropertyType == typeof(bool))
            {
                if (e.StringValue == Text_Yes)
                    e.TypedValue = true;
                else
                    e.TypedValue = false;
                // Note that you must indicate that you have converted the value
                e.IsConverted = true;
            }
        }

        // Provide list of all available property values in text representation, if applicable
        private void advPropertyGrid1_ProvidePropertyValueList(object sender, PropertyValueListEventArgs e)
        {
            if (e.PropertyDescriptor.PropertyType == typeof(bool))
            {
                // Text representation of all available property values
                e.ValueList = new List<string>(new string[] { Text_Yes, Text_No });
                // Indicate that a list was provided
                e.IsListValid = true;
            }
        }

        private void FormPropertyValuesTranslationMethod1_Load(object sender, EventArgs e)
        {
            advPropertyGrid1.SelectedObject = buttonX1;
        }
    }
}