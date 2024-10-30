using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace MovieMeta
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=db-2024-bruhigita3932.cnsalab.net;Username=bruhigita3932;Password=yNIIwNNBO7MW4O7cUhzK;Database=dvdrental";

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(
                    "SELECT Title, ReleaseYear, Length, Rating FROM Movies ORDER BY Title", conn);
                DataTable moviesTable = new DataTable();
                adapter.Fill(moviesTable);
                dataGridView1.DataSource = moviesTable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchingBox(object sender, EventArgs e)
        {

        }

        private void SearchButton(object sender, EventArgs e)
        {
            string searchText = SearchingBox.Text;

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT Title, ReleaseYear, Length, Rating FROM Movies WHERE Title ILIKE @Title ORDER BY Title", conn);
                DataTable filteredTable = new DataTable();
                adapter.Fill(filteredTable);
                dataGridView1.DataSource = filteredTable;
            }
        }

        private void FilterOutRatingsButton(object sender, EventArgs e)
        {
            string excludedRating = ratingComboBox.Text; // Assumes ComboBox for excluded rating

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(
                    "SELECT Title, ReleaseYear, Length, Rating FROM Movies WHERE Rating != @Rating ORDER BY Title", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Rating", excludedRating);
                DataTable excludedTable = new DataTable();
                adapter.Fill(excludedTable);
                dataGridView1.DataSource = excludedTable;
            }
        }

        private void FilterByRatingButton(object sender, EventArgs e)
        {
            string selectedRating = ratingComboBox.Text; // Assumes ComboBox named ratingComboBox for rating options

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(
                    "SELECT Title, ReleaseYear, Length, Rating FROM Movies WHERE Rating = @Rating ORDER BY Title", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Rating", selectedRating);
                DataTable ratingTable = new DataTable();
                adapter.Fill(ratingTable);
                dataGridView1.DataSource = ratingTable;
            }
        }

        private void FilterByCategoryButton(object sender, EventArgs e)
        {
            string selectedCategory = categoryComboBox.Text; // Assumes ComboBox for category selection

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(
                    "SELECT Title, ReleaseYear, Length, Rating FROM Movies WHERE Category = @Category ORDER BY Title", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Category", selectedCategory);
                DataTable categoryTable = new DataTable();
                adapter.Fill(categoryTable);
                dataGridView1.DataSource = categoryTable;
            }
        }

        private void FilterByTitleButton(object sender, EventArgs e)
        {
            string titleFilter = titleTextBox.Text; // Assumes TextBox named titleTextBox for title filtering

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(
                    "SELECT Title, ReleaseYear, Length, Rating FROM Movies WHERE Title ILIKE @TitleFilter ORDER BY Title", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@TitleFilter", $"%{titleFilter}%");
                DataTable titleFilteredTable = new DataTable();
                adapter.Fill(titleFilteredTable);
                dataGridView1.DataSource = titleFilteredTable;
            }
        }
    }
}
