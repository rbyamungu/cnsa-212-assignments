using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DieRoller
{
    public partial class Form1 : Form
    {
        private Tumbler tumbler;
        private List<int> dieTypes;

        public Form1()
        {
            InitializeComponent();
            tumbler = new Tumbler();
            dieTypes = new List<int> { 4, 6, 8, 10, 12, 20, 100 };
            InitializeDieTypeComboBox();
        }

        private void InitializeDieTypeComboBox()
        {
            comboBox1.Items.Clear();
            foreach (var type in dieTypes)
            {
                comboBox1.Items.Add($"d{type}");
            }
            comboBox1.SelectedIndex = 0; // Default selection
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear previous results
            listBox1.Items.Clear();
            tumbler.dice.Clear();

            // Validate die count input
            if (!int.TryParse(textBox1.Text, out int numberOfDice) || numberOfDice <= 0)
            {
                MessageBox.Show("Please enter a valid integer for die count.");
                return;
            }

            // Get selected die type
            int selectedDieSides = dieTypes[comboBox1.SelectedIndex];

            // Create and add dice to the tumbler
            for (int i = 0; i < numberOfDice; i++)
            {
                tumbler.dice.Add(new Die(selectedDieSides));
            }

            // Roll the tumbler and display results
            List<int> results = tumbler.Roll();
            int total = results.Sum();
            foreach (var result in results)
            {
                listBox1.Items.Add(result);
            }
            textBox3.Text = total.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Handle any specific behavior when die type changes
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle any specific behavior when die count input changes
        }
    }

    public class Die
    {
        public int Sides { get; private set; }
        private Random random;

        public Die(int sides)
        {
            Sides = sides;
            random = new Random();
        }

        public int Roll()
        {
            return random.Next(1, Sides + 1);
        }
    }

    public class Tumbler
    {
        public List<Die> dice { get; private set; }

        public Tumbler()
        {
            dice = new List<Die>();
        }

        public List<int> Roll()
        {
            return dice.Select(d => d.Roll()).ToList();
        }
    }
}
