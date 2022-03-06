namespace Library_kku2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonChickin_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add(new string[] { "major","id", "name", "lastname" });
        }

        private void buttonChackout_Click(object sender, EventArgs e)
        {

        }
    }
}