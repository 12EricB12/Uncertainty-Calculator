using System.Runtime.InteropServices;

namespace UncertaintyCalculator
{
    public partial class UncertaintyCalculator : Form
    {
        Helper h = new Helper();
        Calculations c = new Calculations();

        public UncertaintyCalculator()
        {
            InitializeComponent();
        }

        #region Driver
        private void initial1_TextChanged(object sender, EventArgs e)
        {
            SetAddSubtractValues();
        }

        private void initial2_TextChanged(object sender, EventArgs e)
        {
            SetAddSubtractValues();
        }

        private void final1_TextChanged(object sender, EventArgs e)
        {
            SetAddSubtractValues();
        }

        private void final2_TextChanged(object sender, EventArgs e)
        {
            SetAddSubtractValues();
        }

        private void zValMD_TextChanged(object sender, EventArgs e)
        {
            SetMDValues();
        }

        private void xValMD_TextChanged(object sender, EventArgs e)
        {
            SetMDValues();
        }

        private void yValMD_TextChanged(object sender, EventArgs e)
        {
            SetMDValues();
        }

        private void deltaXValueMD_TextChanged(object sender, EventArgs e)
        {
            SetMDValues();
        }

        private void deltaYValueMD_TextChanged(object sender, EventArgs e)
        {
            SetMDValues();
        }

        private void zValPow_TextChanged(object sender, EventArgs e)
        {
            SetPowerValues();
        }

        private void xValPow_TextChanged(object sender, EventArgs e)
        {
            SetPowerValues();
        }

        private void deltaXPow_TextChanged(object sender, EventArgs e)
        {
            SetPowerValues();
        }

        private void powerVal_TextChanged(object sender, EventArgs e)
        {
            SetPowerValues();
        }
        #endregion

        #region Setters
        public void SetAddSubtractValues()
        {
            string[] values = { initial1.Text, initial2.Text, final1.Text, final2.Text };

            if (!h.Validate(values))
            {
                return;
            }

            double i1 = Convert.ToDouble(initial1.Text);
            double i2 = Convert.ToDouble(initial2.Text);
            double f1 = Convert.ToDouble(final1.Text);
            double f2 = Convert.ToDouble(final2.Text);

            double fVal = c.findFinalValue(c.findTwoNumAvg(i1, i2), c.findTwoNumAvg(f1, f2));
            double fDelta = c.findPlusMinusDelta(i1, i2, f1, f2);

            finalValueAVG.Text = Convert.ToString(fVal);
            finalUncertainty.Text = Convert.ToString(fDelta);
        }

        public void SetMDValues() {
            string[] values = { zValMD.Text, xValMD.Text, yValMD.Text, deltaXValueMD.Text, deltaYValueMD.Text};

            if (!h.Validate(values))
            {
                return;
            }

            double z = Convert.ToDouble(zValMD.Text);
            double x = Convert.ToDouble(xValMD.Text);
            double y = Convert.ToDouble(yValMD.Text);
            double deltaX = Convert.ToDouble(deltaXValueMD.Text);
            double deltaY = Convert.ToDouble(deltaYValueMD.Text);

            double zDelta = c.findMultiDivDelta(z, x, y, deltaX, deltaY);

            deltaZValMD.Text = Convert.ToString(zDelta);
        }

        public void SetPowerValues() {
            string[] values = { zValPow.Text, xValPow.Text, deltaXPow.Text, powerVal.Text };

            if (!h.Validate(values))
            {
                return;
            }

            double z = Convert.ToDouble(zValPow.Text);
            double x = Convert.ToDouble(xValPow.Text);
            double deltaX = Convert.ToDouble(deltaXPow.Text);
            double power = Convert.ToDouble(powerVal.Text);

            double powDelta = c.findPowDelta(z, x, deltaX, power);

            deltaZValPow.Text = Convert.ToString(powDelta);
        }
        #endregion
    }

    class Helper {
        public bool Validate(params string[] values) {
            foreach (string val in values) {
                bool isDouble = Double.TryParse(val, out double d);

                if (String.IsNullOrEmpty(val) || !isDouble) return false;
            }

            return true;
        }
    }
}
