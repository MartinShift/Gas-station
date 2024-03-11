using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Zapravka
{
    public partial class Form1 : Form
    {
        public int[] benzinPrices = { 40, 45, 50, 60, 45, 35, 40 };
        public int TotalMoney { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
            PetrolPriceBox.ReadOnly = true;
        }
        private void PetrolChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            PetrolPriceBox.Text = benzinPrices[PetrolChoose.SelectedIndex].ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CountCafe(object sender, EventArgs e)
        {
            try
            {
                int num = 0;
                num += int.Parse(HotDogPrice.Text) * int.Parse(HotDogQuantityBox.Text);
                num += int.Parse(BurgerPrice.Text) * int.Parse(BurgerQuantityBox.Text);
                num += int.Parse(FriesPrice.Text) * int.Parse(FriesQuantityBox.Text);
                num += int.Parse(ColaPrice.Text) * int.Parse(ColaQuantityBox.Text);
                CafeTotalLabel.Text = num.ToString();
            }
            catch (Exception) { }
        }
        private void CountByPetrol(object sender, EventArgs e)
        {
            if (PetrolChoose.SelectedIndex==-1)
            {
                MessageBox.Show("Select Fuel type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                PetrolTotalLabel.Text = (double.Parse(PetrolBox.Text)*double.Parse(PetrolPriceBox.Text)).ToString();

            }
            catch (Exception) { }
        }
        private void CountBySum(object sender, EventArgs e)
        {
            if (PetrolChoose.SelectedIndex == -1)
            {
                MessageBox.Show("Select Fuel type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                PetrolBox.Text = (double.Parse(SumBox.Text) / double.Parse(PetrolPriceBox.Text)).ToString();
                PetrolTotalLabel.Text = SumBox.Text;
            }
            catch (Exception) { }
        }
        private void CountTotal(object sender,EventArgs e)
        {
            TotalLabel.Text = (double.Parse(PetrolTotalLabel.Text) + double.Parse(CafeTotalLabel.Text)).ToString(
                );
        }
        private void HotDogBox_CheckedChanged(object sender, EventArgs e)
        {
            HotDogQuantityBox.ReadOnly = !HotDogBox.Checked;
            HotDogQuantityBox.BackColor = HotDogBox.Checked ? Color.White : SystemColors.ScrollBar;
            if (!HotDogBox.Checked)
            {
                HotDogQuantityBox.Text = "0";
            }
        }
        private void BurgerBox_CheckedChanged(object sender, EventArgs e)
        {
            BurgerQuantityBox.ReadOnly = !BurgerBox.Checked;
            BurgerQuantityBox.BackColor = BurgerBox.Checked ? Color.White : SystemColors.ScrollBar;
            if (!BurgerBox.Checked)
            {
                BurgerQuantityBox.Text = "0";
            }
        }
        private void FriesBox_CheckedChanged(object sender, EventArgs e)
        {
            FriesQuantityBox.ReadOnly = !FriesBox.Checked;
            FriesQuantityBox.BackColor = FriesBox.Checked ? Color.White : SystemColors.ScrollBar;
            if (!FriesBox.Checked)
            {
                FriesQuantityBox.Text = "0";
            }
        }
        private void ColaBox_CheckedChanged(object sender, EventArgs e)
        {
            ColaQuantityBox.ReadOnly = !ColaBox.Checked;
            ColaQuantityBox.BackColor = ColaBox.Checked ? Color.White : SystemColors.ScrollBar;
            if (!ColaBox.Checked)
            {
                ColaQuantityBox.Text = "0";
            }
        }
        private void FuelAmountChoice_CheckedChanged(object sender, EventArgs e)
        {
            SumAmountChoice.Checked = !FuelAmountChoice.Checked;
            PetrolBox.ReadOnly = !FuelAmountChoice.Checked;
            PetrolBox.BackColor = FuelAmountChoice.Checked ? Color.White : SystemColors.ScrollBar;
            PetrolBox.Text = "";
        }
        private void SumAmountChoice_CheckedChanged(object sender, EventArgs e)
        {
            FuelAmountChoice.Checked = !SumAmountChoice.Checked;
            SumBox.ReadOnly = !SumAmountChoice.Checked;
            SumBox.BackColor = SumAmountChoice.Checked ? Color.White : SystemColors.ScrollBar;
            SumBox.Text = "";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
