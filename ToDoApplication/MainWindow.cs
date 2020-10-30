using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ToDoApplication
{
    public partial class MainWindow : Form
    {
        MySqlConnection connection;
        string connectionString;

        public MainWindow()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["todoapp.Properties.Settings.TodoAppConnectionString"].ConnectionString;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadingTasks();
        }

        private void LoadingTasks()
        {
            connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand("SELECT * FROM tasks", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            
            DataTable taskTable = new DataTable();
            adapter.Fill(taskTable);

            lstTasksBox.DisplayMember = "TaskTitle";
            lstTasksBox.ValueMember = "id";
            lstTasksBox.DataSource = taskTable;
            connection.Close();
            
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tasks (taskTitle, taskDescription, taskDate) VALUES (@taskTitle, @taskDescription, @taskDate)";

            connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            
            connection.Open();

            command.Parameters.AddWithValue("@taskTitle", txtTaskTitle.Text);
            command.Parameters.AddWithValue("@taskDescription", txtTaskDesc.Text);
            command.Parameters.AddWithValue("@taskDate", DateTime.Now);

            command.ExecuteNonQuery();

            txtTaskTitle.Clear();
            txtTaskDesc.Clear();
            

            LoadingTasks();
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            string query = "UPDATE tasks SET taskTitle = @taskTitle , taskDescription = @taskDescription WHERE id = @id";

            connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            
            connection.Open();

            command.Parameters.AddWithValue("@taskTitle", txtTaskTitle.Text);
            command.Parameters.AddWithValue("@taskDescription", txtTaskDesc.Text);
            command.Parameters.AddWithValue("@id", lstTasksBox.SelectedValue);

            command.ExecuteScalar();

            txtTaskTitle.Clear();
            txtTaskDesc.Clear();
            

            LoadingTasks();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM tasks WHERE id = @id";

            connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            
            connection.Open();

            command.Parameters.AddWithValue("@id", lstTasksBox.SelectedValue);

            command.ExecuteNonQuery();
            

            LoadingTasks();
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand("SELECT * FROM tasks WHERE id = @id", connection);
            
            connection.Open();
            command.Parameters.AddWithValue("@id", lstTasksBox.SelectedValue);
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                txtTaskTitle.Text = read.GetValue(1).ToString();
                txtTaskDesc.Text = read.GetValue(2).ToString();
            }

            LoadingTasks();
        }

        private void btnTaskTitleDel_Click(object sender, EventArgs e)
        {
            txtTaskTitle.Clear();
            txtTaskDesc.Clear();
        }

        private void btnReadTask_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand("SELECT * FROM tasks WHERE id = @id", connection);

            connection.Open();
            command.Parameters.AddWithValue("@id", lstTasksBox.SelectedValue);
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                string tTitle = read.GetValue(1).ToString();
                string tDesc = read.GetValue(2).ToString();
                string date = read.GetValue(3).ToString();
                MessageBox.Show("Task title: " + tTitle + "\n" +
                    "Task Description: " + tDesc + "\n" +
                    "Task date created: " + date);
            }
        }

        private void lstTasksBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
