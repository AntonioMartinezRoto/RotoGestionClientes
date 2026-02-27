using System;
using System.Collections.Generic;
using System.Text;
using static RotoGestionClientes.Enums;

namespace RotoGestionClientes
{
    public class WizardStepItem : Panel
    {
        private Label lblNumber;
        private Label lblTitle;
        public event EventHandler? StepClicked;

        public WizardStepItem(string number, string title, WizardMode wizardMode)
        {
            Height = 44;
            Dock = DockStyle.None;
            Margin = new Padding(4);
            Padding = new Padding(10);
            Cursor = Cursors.Hand;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            AutoSize = false;

            lblNumber = new Label
            {
                Text = number,
                Width = 30,
                Dock = DockStyle.Left,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand
            };

            lblTitle = new Label
            {
                Text = title,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 9),
                Cursor = Cursors.Hand
            };

            Controls.Add(lblTitle);

            if (wizardMode == WizardMode.Create)
            {
                Controls.Add(lblNumber);
            }

            RegisterClickRecursive(this);
        }

        public void SetActive()
        {
            BackColor = Color.FromArgb(0, 120, 212);
            ForeColor = Color.White;
        }

        public void SetCompleted()
        {
            BackColor = Color.FromArgb(16, 124, 16);
            ForeColor = Color.White;
        }

        public void SetPending()
        {
            BackColor = Color.Transparent;
            ForeColor = Color.Black;
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            StepClicked?.Invoke(this, EventArgs.Empty);
        }
        private void RegisterClickRecursive(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                ctrl.Click += (s, e) => OnClick(e);

                if (ctrl.HasChildren)
                    RegisterClickRecursive(ctrl);
            }
        }
    }


}
