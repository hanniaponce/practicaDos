using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDos
{
    
    public partial class Form1 : Form
    {
        private string selectedImagePath = string.Empty; 
        private ImageList imageList = new ImageList(); 

        public Form1()
        {
            InitializeComponent();
            lstBoxImage.SelectedIndexChanged += imageListBox_SelectedIndexChanged;
        }

        
        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    lstBoxImage.Items.Clear();
                    imageList.Images.Clear(); 

                  
                    string[] imageFiles = Directory.GetFiles(folderDialog.SelectedPath, "*.jpg");

                    foreach (string file in imageFiles)
                    {
                      
                        Image img = Image.FromFile(file);
                        Image thumb = img.GetThumbnailImage(200, 200, null, IntPtr.Zero); // Miniaturas de 200x200 píxeles

                        
                        imageList.Images.Add(thumb);

                        
                        lstBoxImage.Items.Add(file);
                    }

                    
                    lstBoxImage.DrawMode = DrawMode.OwnerDrawVariable;
                    lstBoxImage.MeasureItem += imageListBox_MeasureItem;
                    lstBoxImage.DrawItem += imageListBox_DrawItem;
                }
            }
        }

        
        private void imageListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 200;
        }

        
        private void imageListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            
            Image img = imageList.Images[e.Index];

            
            e.Graphics.DrawImage(img, e.Bounds.Left, e.Bounds.Top);
        }

       
        private void imageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxImage.SelectedItem != null)
            {
                selectedImagePath = lstBoxImage.SelectedItem.ToString();
            }
        }

        
        private void btnVer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Por favor selecciona una imagen.");
                return;
            }

            Form fullScreenForm = new Form
            {
                Text = Path.GetFileName(selectedImagePath),
                Size = new Size(600, 600), 
                StartPosition = FormStartPosition.CenterScreen
            };

            PictureBox pictureBox = new PictureBox
            {
                Image = Image.FromFile(selectedImagePath),
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill
            };

            fullScreenForm.Controls.Add(pictureBox);
            fullScreenForm.ShowDialog();
        }

    
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Por favor selecciona una imagen.");
                return;
            }

            var confirmResult = MessageBox.Show($"¿Estás seguro de eliminar {Path.GetFileName(selectedImagePath)}?",
                                                "Confirmar eliminación",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    
                    File.Delete(selectedImagePath);

                    
                    int selectedIndex = lstBoxImage.SelectedIndex;
                    lstBoxImage.Items.RemoveAt(selectedIndex);

                    
                    imageList.Images.RemoveAt(selectedIndex);

                    MessageBox.Show("Imagen eliminada con éxito.");
                    selectedImagePath = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la imagen: {ex.Message}");
                }
            }
        }
    }
}