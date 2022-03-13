using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TicketSYS
{
    internal class Utilities
    {
        public static void ResetFormControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }

                if (control.GetType() == typeof(ComboBox) && control.Name != "cboCounty")
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.Items.Clear();
                } else if(control.Name == "cboCounty")
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = 0;
                }

                if (control.GetType() == typeof(NumericUpDown))
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = numericUpDown.Minimum;
                }
            }
        }
    }
}
