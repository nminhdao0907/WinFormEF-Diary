using NhatKi2023.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NhatKi2023
{
    public partial class Home : Form
    {
        dynamic entryList;
        public Home()
        {
            InitializeComponent();
        }

        Nhatki2023Context context = new Nhatki2023Context();
        Dictionary<int, RadioButton> rbtn = new Dictionary<int, RadioButton>();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer
        {
            Interval = 1000,
        };

        int count = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            cbStatus.DataSource = context.Entries.Select(x => x.Status).Distinct().ToList();
            cbStatus.SelectedIndex = 1;
            LoadEntry();
        }
        private void LoadEntry()
        {
            try
            {
                var data = (from item in context.Entries
                            join item2 in context.Tags on item.TagId equals item2.TagId
                            select new
                            {
                                ID = item.EntryId,
                                Date = item.EntryDate,
                                Title = item.Title,
                                Story = item.Content,
                                Tag = item.Tag.TagName,
                                Status = item.Status
                            }).ToList();

                dgDiary.DataSource = data;
                dgDiary.Columns["ID"].HeaderText = "ID Number";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load data error: " + ex.Message);
                throw;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            timer.Stop();
            count = 0;
            string tagName = txtHashtag.Text;
            string title = txtTitle.Text;
            string content = rtContent.Text;
            if (string.IsNullOrEmpty(tagName) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Please fullfill the entry", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else
            {
                using (Nhatki2023Context context = new Nhatki2023Context())
                {
                    Tag existedTag = context.Tags.FirstOrDefault(t => t.TagName == tagName);

                    if (existedTag == null)
                    {
                        Tag newTag = new Tag
                        {
                            TagName = tagName,
                        };
                        context.Tags.Add(newTag);
                        context.SaveChanges();

                        Entry entries = new Entry()
                        {
                            Title = txtTitle.Text,
                            EntryDate = DateTime.Parse(dtDate.Value.ToShortDateString()),
                            Content = rtContent.Text,
                            Tag = newTag
                        };
                        context.Entries.Add(entries);

                    }
                    else
                    {
                        Entry entries = new Entry()
                        {
                            Title = txtTitle.Text,
                            EntryDate = DateTime.Parse(dtDate.Value.ToShortDateString()),
                            Content = rtContent.Text,
                            Tag = existedTag
                        };
                        context.Entries.Add(entries);
                    }
                    context.SaveChanges();
                }
                txtTitle.Clear();
                rtContent.Clear();
                txtHashtag.Clear();
                LoadEntry();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string tagName = txtHashtag.Text;
            string title = txtTitle.Text;
            string content = rtContent.Text;

            if (string.IsNullOrEmpty(tagName) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Please fullfill the entry", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else
            {
                using (Nhatki2023Context context = new Nhatki2023Context())
                {
                    Entry entries = context.Entries.FirstOrDefault(e => e.EntryId == Int32.Parse(txtId.Text));
                    if (entries != null)
                    {
                        entries.Title = txtTitle.Text;
                        entries.EntryDate = DateTime.Parse(dtDate.Value.ToShortDateString());
                        entries.Content = rtContent.Text;

                        Tag existedTag = context.Tags.FirstOrDefault(t => t.TagName == tagName);
                        if (existedTag != null)
                        {
                            entries.Tag = existedTag;
                        }
                        else
                        {
                            Tag newTag = new Tag
                            {
                                TagName = tagName
                            };
                            context.Tags.Add(newTag);
                            entries.Tag = newTag;
                        }
                        MessageBox.Show("Updated successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        context.SaveChanges();
                        dgDiary.Refresh();
                        LoadEntry();
                    }
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            dtDate.Value = DateTime.Now;
            txtTitle.Clear();
            rtContent.Clear();
            txtHashtag.Clear();
            dgDiary.Refresh();
            LoadEntry();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            timer.Stop();
            count = 0;
            try
            {
                using (Nhatki2023Context context = new Nhatki2023Context())
                {
                    Entry entries = context.Entries.FirstOrDefault(e => e.EntryId == Int32.Parse(txtId.Text));
                    if (entries != null)
                    {
                        bool isTaged = context.Entries.Any(e => e.TagId == entries.TagId && e.EntryId != Int32.Parse(txtId.Text));
                        context.Entries.Remove(entries);
                        context.SaveChanges();
                        if (!isTaged)
                        {
                            Tag tag = context.Tags.FirstOrDefault(t => t.TagId == entries.TagId);
                            if (tag != null)
                            {
                                context.Tags.Remove(tag);
                                context.SaveChanges();
                            }
                        }
                        MessageBox.Show("Delete Successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEntry();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete: " + ex.Message);
                throw;
            }

        }
        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var data = context.Entries
                .Where(e => e.Title.Contains(txtSearch.Text) && e.Status.Equals(cbStatus.SelectedItem))
                .Select(e => new
                {
                    Id = e.EntryId,
                    Date = e.EntryDate,
                    Title = e.Title,
                    Story = e.Content,
                    Tag = e.Tag.TagName,
                    Status = e.Status
                }).ToList();
                dgDiary.DataSource = data;

                var data2 = context.Tags.ToList();


                txtId.DataBindings.Clear();
                txtId.DataBindings.Add("Text", data, "Id");
                dtDate.DataBindings.Clear();
                dtDate.DataBindings.Add("Value", data, "Date");
                txtTitle.DataBindings.Clear();
                txtTitle.DataBindings.Add("Text", data, "Title");
                rtContent.DataBindings.Clear();
                rtContent.DataBindings.Add("Text", data, "Story");
                txtHashtag.DataBindings.Clear();
                txtHashtag.DataBindings.Add("Text", data, "Tag");
                cbFavourite.DataBindings.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
                throw;
            }

        }

        private void dgDiary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewRow row = dgDiary.Rows[e.RowIndex];
            int entryId = Convert.ToInt32(row.Cells["ID"].Value);
            using (Nhatki2023Context context = new Nhatki2023Context())
            {
                var data = context.Entries.Where(e => e.EntryId == entryId)
                    .Select(e => new
                    {
                        ID = e.EntryId,
                        Date = e.EntryDate,
                        Title = e.Title,
                        Story = e.Content,
                        Tag = e.Tag.TagName,
                        Status = e.Status
                    }).ToList();

                txtId.DataBindings.Clear();
                txtId.DataBindings.Add("Text", data, "ID");
                dtDate.DataBindings.Clear();
                dtDate.DataBindings.Add("Value", data, "Date");
                txtTitle.DataBindings.Clear();
                txtTitle.DataBindings.Add("Text", data, "Title");
                rtContent.DataBindings.Clear();
                rtContent.DataBindings.Add("Text", data, "Story");
                txtHashtag.DataBindings.Clear();
                txtHashtag.DataBindings.Add("Text", data, "Tag");
                cbFavourite.DataBindings.Clear();
                cbFavourite.DataBindings.Add("Checked", data, "Status", true, DataSourceUpdateMode.Never, false);
            }
        }

        private void dtDate_Enter(object sender, EventArgs e)
        {
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            txtTitle.BackColor = Color.Gainsboro;
        }
        private void txtTitle_Leave(object sender, EventArgs e)
        {
            txtTitle.BackColor = Color.WhiteSmoke;
        }

        private void Home_MouseLeave(object sender, EventArgs e)
        {
            timer.Start();
            count = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void txtHashtag_Leave(object sender, EventArgs e)
        {
            txtHashtag.BackColor = Color.WhiteSmoke;
        }

        private void txtHashtag_Enter(object sender, EventArgs e)
        {
            txtHashtag.BackColor = Color.Gainsboro;
        }

        private void cbFavourite_CheckedChanged(object sender, EventArgs e)
        {
            using (Nhatki2023Context context = new Nhatki2023Context())
            {
                Entry entries = context.Entries.FirstOrDefault(e => e.EntryId == Int32.Parse(txtId.Text));
                if (entries != null)
                {
                    entries.Status = cbFavourite.Checked ? true : false;
                    context.SaveChanges();
                    LoadEntry();
                }
            }
        }
        private void btnViewFavour_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyFavourite m = new MyFavourite();
            m.Show();
        }

        private void dgDiary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

