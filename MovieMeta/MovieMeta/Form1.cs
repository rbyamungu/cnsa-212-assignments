using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Npgsql;


namespace MovieMeta
{
    public partial class Form1 : Form
    {
        private string dvdrentServer = "Host=db-2024-bruhigita3932.cnsalab.net;Username=bruhigita3932;Password=yNIIwNNBO7MW4O7cUhzK;Database=dvdrental";

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(dvdrentServer))
                {
                    conn.Open();
                    string query = "SELECT title AS \"Title\", release_year AS \"Release Year\", length AS \"Length\", rating AS \"Rating\" FROM film";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    DataTable moviesTable = new DataTable();
                    adapter.Fill(moviesTable);
                    dataGridView1.DataSource = moviesTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        
        private void SearchButton(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(dvdrentServer))
                {
                    conn.Open();
                    string query = "SELECT title AS \"Title\", release_year AS \"Release Year\", length AS \"Length\", rating AS \"Rating\" FROM film WHERE title ILIKE @Title ORDER BY title";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@Title", $"%{searchText}%");
                    DataTable filteredTable = new DataTable();
                    adapter.Fill(filteredTable);
                    dataGridView1.DataSource = filteredTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void FilterOutRatingsButton(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(dvdrentServer))
                {
                    conn.Open();
                    string query = "SELECT title AS \"Title\", release_year AS \"Release Year\", length AS \"Length\", rating AS \"Rating\" " +
                            "FROM film " +
                            "WHERE rating <> 'NC-17' " +  // Exclude NC-17 movies
                            "ORDER BY rating";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    DataTable filteredTable = new DataTable();
                    adapter.Fill(filteredTable);
                    dataGridView1.DataSource = filteredTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void FilterByRatingButton(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(dvdrentServer))
                {
                    conn.Open();
                    string query = "SELECT title AS \"Title\", release_year AS \"Release Year\", length AS \"Length\", rating AS \"Rating\" FROM film ORDER BY rating";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);        
                    DataTable filteredTable = new DataTable();
                    adapter.Fill(filteredTable);
                    dataGridView1.DataSource = filteredTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void FilterByCategoryButton(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(dvdrentServer))
                {
                    conn.Open();
                    string query = "SELECT f.title AS \"Title\", f.release_year AS \"Release Year\", f.length AS \"Length\", f.rating AS \"Rating\", c.name AS \"Category Name\" FROM film f JOIN film_category fc ON f.film_id = fc.film_id JOIN category c ON fc.category_id = c.category_id  ORDER BY c.name";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    DataTable filteredTable = new DataTable();
                    adapter.Fill(filteredTable);
                    dataGridView1.DataSource = filteredTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void FilterByTitleButton(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(dvdrentServer))
                {
                    conn.Open();
                    string query = "SELECT title AS \"Title\", release_year AS \"Release Year\", length AS \"Length\", rating AS \"Rating\" FROM film ORDER BY title";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    DataTable filteredTable = new DataTable();
                    adapter.Fill(filteredTable);
                    dataGridView1.DataSource = filteredTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        
    }
}
