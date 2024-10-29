namespace GradeCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // List to store inputted grades
            List<double> grades = new List<double>();
            bool hasInvalidInput = false; // Check to see if there were any invalid inputs.

            // Get all the entries put into the table.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //Find all of the new entries
                if (!row.IsNewRow && row.Cells.Count > 0)
                {
                    // Get the value from the first cell with a grade value
                    if (row.Cells[0].Value != null)
                    {
                        // Try to parse the value as an integer
                        if (int.TryParse(row.Cells[0].Value.ToString(), out int parsedGrade))
                        {
                            // Check if the grade is between 0 and 150 (in case of bonus points)
                            if (parsedGrade >= 0 && parsedGrade <= 150)
                            {
                                grades.Add(parsedGrade); // Add valid grade to the list
                            }
                            else
                            {
                                hasInvalidInput = true; // Mark as invalid input if out of range
                            }
                        }
                        else
                        {
                            hasInvalidInput = true; // Mark as invalid input if parsing fails
                        }
                    }
                }
                // If there are invalid inputs, show a message box
                if (hasInvalidInput)
                {
                    MessageBox.Show("The Cooker! Please enter valid grades (0-150).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if there's invalid input
                }

                // Calculate the mean and median of all the inputted grades
                if (grades.Count > 0)
                {
                    // Calculate mean
                    double mean = grades.Average();
                    textBox2.Text = mean.ToString("F2"); // Display mean in textBox2

                    // Calculate median
                    grades.Sort(); // Sort the grades
                    double median;
                    int count = grades.Count;

                    // Check if count is even or odd
                    if (count % 2 == 0) // Even number of grades
                    {
                        median = (grades[count / 2 - 1] + grades[count / 2]) / 2.0;
                    }
                    else // Odd number of grades
                    {
                        median = grades[count / 2];
                    }
                    textBox1.Text = median.ToString("F2"); // Display median in textBox1
                }
                else
                {
                    // If no valid grades were entered, display 0.00
                    textBox2.Text = "0.00"; // Default mean
                    textBox1.Text = "0.00"; // Default median
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
