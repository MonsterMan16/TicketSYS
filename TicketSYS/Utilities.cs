using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace TicketSYS
{
    internal class Utilities
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                ResetControl(control);
            }
        }

        private static void ResetControl(Control control)
        {
            if (control.HasChildren)
            {
                foreach(Control child in control.Controls)
                {
                    ResetControl(child);
                }
            }
            switch (control.GetType().Name)
            {
                case "TextBox":
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                    break;
                case "ComboBox":
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        if (comboBox.Name == "cboCounty")
                        {
                            comboBox.SelectedIndex = 0;
                        } else
                        {
                            comboBox.Items.Clear();
                            comboBox.Items.Add("");
                            comboBox.SelectedIndex = 0;
                        }
                    break;
                //case "CheckBox":
                //        CheckBox checkBox = (CheckBox)control;
                //        checkBox.Checked = false;
                //    break;
                case "ListBox":
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                    break;
                case "NumericUpDown":
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = numericUpDown.Minimum;
                    break;
                case "DateTimePicker":
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.Value = DateTime.Now;
                    dateTimePicker.MinDate = DateTime.Now;
                    break;
            }
        }
    }
}
