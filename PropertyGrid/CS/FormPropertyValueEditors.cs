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
    public partial class FormPropertyValueEditors : Office2007Form
    {
        public FormPropertyValueEditors()
        {
            InitializeComponent();
        }

        private void FormPropertyValueEditors_Load(object sender, EventArgs e)
        {
            // Property setting applies to property name: TrackBarDynamic
            PropertySettings propertySetting = new PropertySettings("TrackBarDynamic");
            // Assign our custom property value editor
            propertySetting.ValueEditor = new TrackBarPropertyEditor(0, 100);
            advPropertyGrid1.PropertySettings.Add(propertySetting);

            CustomClass custom = new CustomClass();
            custom.PropertyChanged += new PropertyChangedEventHandler(CustomClassPropertyChanged);
            advPropertyGrid1.SelectedObject = custom;
        }

        void CustomClassPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("Property Change {0}, Value: {1}", e.PropertyName, TypeDescriptor.GetProperties(advPropertyGrid1.SelectedObject)[e.PropertyName].GetValue(advPropertyGrid1.SelectedObject));
        }
    }

    /// <summary>
    /// Defines the custom attribute that can be used to decorate properties
    /// or assigned to property settings.
    /// </summary>
    public class TrackBarPropertyEditor : PropertyValueEditor
    {
        /// <summary>
        /// Minimum track bar value.
        /// </summary>
        public int Minimum = 0;
        /// <summary>
        /// Maximum track bar value.
        /// </summary>
        public int Maximum = 100;

        /// <summary>
        /// Initializes a new instance of the TrackBarPropertyEditor class.
        /// </summary>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        public TrackBarPropertyEditor(int minimum, int maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        /// <summary>
        /// Creates the control that is used in AdvPropertyGrid to edit property value.
        /// </summary>
        public override IPropertyValueEditor CreateEditor(PropertyDescriptor propertyDescriptor, object targetObject)
        {
            // We use custom control that implements IPropertyValueEditor interface
            TrackBarEditor editor = new TrackBarEditor();
            editor.Minimum = Minimum;
            editor.Maximum = Maximum;

            editor.TickStyle = TickStyle.None;
            editor.AutoSize = false;
            editor.Height = 20;

            return editor;
        }

        /// <summary>
        /// This is actual control that is used in AdvPropertyGrid to edit value.
        /// It must inherit from System.Windows.Forms.Control or its descendants.
        /// </summary>
        private class TrackBarEditor : TrackBar, IPropertyValueEditor
        {
            #region IPropertyValueEditor Members - This interface must be implemented so control can be used by AdvPropertyGrid
            /// <summary>
            /// Gets or sets the value being edited.
            /// </summary>
            public object EditValue
            {
                get
                {
                    return this.Value;
                }
                set
                {
                    this.Value = (int)value;
                }
            }

            /// <summary>
            /// This provides notification back to the property grid that value in editor has changed by raising EditValueChanged event.
            /// </summary>
            /// <param name="e"></param>
            protected override void OnValueChanged(EventArgs e)
            {
                OnEditValueChanged(e);
                base.OnValueChanged(e);
            }
            /// <summary>
            /// Occurs when EditValue changes by the end user. Raising this even will cause the property value to be updated with the EditValue.
            /// </summary>
            public event EventHandler EditValueChanged;
            private void OnEditValueChanged(EventArgs e)
            {
                EventHandler ev = EditValueChanged;
                if (ev != null) ev(this, e);
            }
            /// <summary>
            /// Gets or sets the font used by the edit part of the control. Font might be used to visually indicate that property value has changed. Implementing this property is optional.
            /// </summary>
            public Font EditorFont
            {
                get
                {
                    return this.Font;
                }
                set
                {
                    this.Font = value;
                }
            }
            /// <summary>
            /// Focus the edit part of the control.
            /// </summary>
            public void FocusEditor()
            {
                this.Focus();
            }
            /// <summary>
            /// Gets whether the edit part of the control is focused.
            /// </summary>
            public bool IsEditorFocused
            {
                get { return this.Focused; }
            }

            #endregion
        }

        
    }

    /// <summary>
    /// This is class to demonstrate property-value editors included with AdvPropertyGrid
    /// </summary>
    public class CustomClass : INotifyPropertyChanged
    {
        private double _DoubleValue = 0;
        [PropertyDoubleEditor(0, 100), Description("Uses double value editor with min and max values defined. Min=0, Max=100")]
        public double DoubleValue
        {
            get { return _DoubleValue; }
            set
            {
                _DoubleValue = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DoubleValue"));
            }
        }

        private int _SliderEditor = 0;
        [PropertySliderEditor(-10, 20, true, 40), Description("Office style slider property editor. Min=-10, Max=20")]
        public int SliderEditor
        {
            get { return _SliderEditor; }
            set
            {
                _SliderEditor = value;
                OnPropertyChanged(new PropertyChangedEventArgs("SliderEditor"));
            }
        }

        private string _MultiStringOption;
        [PropertyMultiChoiceEditor("Option 1,Option 2,Option 3")]
        public string MultiStringOption
        {
            get { return _MultiStringOption; }
            set
            {
                _MultiStringOption = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MultiStringOption"));
            }
        }

        private string _MultiSelect;
        [PropertyMultiChoiceEditor("Option 1,Option 2,Option 3", true)]
        public string MultiSelect
        {
            get { return _MultiSelect; }
            set
            {
                _MultiSelect = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MultiSelect"));
            }
        }

        private int _IntegerValue;
        [PropertyIntegerEditor(0, 100), Description("Uses integer value editor with min and max values defined. Min=0, Max=100")]
        public int IntegerValue
        {
            get { return _IntegerValue; }
            set
            {
                _IntegerValue = value;
                OnPropertyChanged(new PropertyChangedEventArgs("IntegerValue"));
            }
        }

        private int _TrackBarDecorated = 20;
        [TrackBarPropertyEditor(0,200), Description("Custom Editor assigned using attribute.")]
        public int TrackBarDecorated
        {
            get { return _TrackBarDecorated; }
            set
            {
                _TrackBarDecorated = value;
                OnPropertyChanged(new PropertyChangedEventArgs("TrackBarDecorated"));
            }
        }

        private int _TrackBarDynamic = 0;
        [Description("Custom Editor assigned through property settings on AdvPropertyGrid")]
        public int TrackBarDynamic
        {
            get { return _TrackBarDynamic; }
            set
            {
                _TrackBarDynamic = value;
                OnPropertyChanged(new PropertyChangedEventArgs("TrackBarDynamic"));
            }
        }

        private DateTime _Date = DateTime.Today;
        [PropertyDateTimeEditor(), Description("Date-Time Editor")]
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; OnPropertyChanged(new PropertyChangedEventArgs("Date")); }
        }

        private DateTime _Time = DateTime.Today;
        [PropertyDateTimeEditor(DevComponents.Editors.eDateTimePickerFormat.ShortTime), Description("Date-Time Editor with format ShortTime")]
        public DateTime Time
        {
            get { return _Time; }
            set { _Time = value; OnPropertyChanged(new PropertyChangedEventArgs("Time")); }
        }

        #region INotifyPropertyChanged Members
        /// <summary>
        /// Occurs when property value has changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Raises the PropertyChanged event.
        /// </summary>
        /// <param name="e">Event arguments</param>
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler eh = PropertyChanged;
            if (eh != null) eh(this, e);
        }
        #endregion
    }
}