using NhatKi2023.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhatKi2023
{
    public partial class MyFavourite : Form
    {
        Nhatki2023Context context = new Nhatki2023Context();
        public MyFavourite()
        {
            InitializeComponent();
        }
        private void LoadFavourites()
        {
            try
            {
                var data = (from item in context.Entries
                            where item.Status.Equals(true)
                            select new
                            {
                                ID = item.EntryId,
                                Date = item.EntryDate,
                                Title = item.Title,
                                Story = item.Content,
                                Tag = item.Tag.TagName,
                                Status = item.Status
                            }).ToList();
                dgFavourite.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load data error: " + ex.Message);
                throw;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgFavourite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MyFavourite_Load(object sender, EventArgs e)
        {
            LoadFavourites();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
